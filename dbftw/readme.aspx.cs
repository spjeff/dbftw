using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DbFtw
{
    public partial class readme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //display version number
            Assembly assembly = Assembly.GetExecutingAssembly();
            string version = assembly.GetName().Version.ToString();
            lblVersion.Text = version;
        }
    }
}