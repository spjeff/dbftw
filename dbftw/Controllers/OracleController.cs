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
            string sql = "";
            for (int i = 1; i < fileContent.Length; i++)
            {
                sql += " " + fileContent[i];
            }

            //populate config object
            detail.connection = fileContent[0];
            detail.command = sql;
            detail.isTable = true;

            //run
            return RunSQL(detail.connection, detail.command, detail.isTable);
        }

        // POST api/values
        public DataTable Post([FromBody]jsonDetail detail)
        {
            //run
            return RunSQL(detail.connection, detail.command, detail.isTable);
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
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                table.Columns.Add("rowsAffected");
                DataRow row = table.NewRow();
                row[0] = rowsAffected;
                table.Rows.Add(row);
                conn.Close();
            }
            return table;
        }
    }
}