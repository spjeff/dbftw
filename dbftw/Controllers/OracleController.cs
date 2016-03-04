using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;

//Oracle
using System.Data.OracleClient;
using System.Data;
using System.IO;
using System.Web.Http.Cors;
using System.Web;


namespace DbFtw.Controllers
{
    // CORS - Enable HTTP calls from any source URL
    //      - To allow specific caller DNS domains only use this syntax:
    //        (origins: "http://domain1, http://domain1",
    [EnableCors(origins: "*",
        headers: "*",
        methods: "*",
        SupportsCredentials = true)]
    [Authorize]
    public class OracleController : ApiController
    {
        // GET api/values
        public void Get()
        {
        }

        // GET api/values/text-file-name
        public DataTable Get(string id)
        {
            //get TXT content
            string path = DbFtw.shared.fixPath(HttpContext.Current.Server.MapPath("."));
            string filePath = path + "\\" + id + ".txt";
            string[] fileContent = System.IO.File.ReadAllLines(filePath);

            //parse TXT
            jsonDetail detail = new jsonDetail();
            string server = fileContent[0];
            string user = fileContent[1];
            string pw = fileContent[2];
            string sql = "";
            for (int i = 4; i < fileContent.Length; i++)
            {
                sql += " " + fileContent[i];
            }

            //populate config object
            string clearPw = Encoding.UTF8.GetString(Convert.FromBase64String(pw));
            detail.connection = String.Format(fileContent[3], server, user, clearPw);
            detail.command = sql;
            detail.isReadOnly = true;

            //run
            return RunSQL(detail.connection, detail.command, detail.isReadOnly);
        }

        // POST api/values
        public DataTable Post([FromBody]jsonDetail detail)
        {
            //run
            return RunSQL(detail.connection, detail.command, detail.isReadOnly);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        private DataTable RunSQL(string connection, string command, bool isReadOnly)
        {
            //execute
            OracleConnection conn = new OracleConnection(connection);
            OracleCommand cmd = new OracleCommand(command, conn);

            //format
            DataTable table = new DataTable("result");
            if (isReadOnly)
            {
                //read
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(table);
            }
            else
            {
                //modify
                int rowsAffected = cmd.ExecuteNonQuery();
                table.Columns.Add("rowsAffected");
                DataRow row = table.NewRow();
                row[0] = rowsAffected;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}