using System.Web;
using System.Web.Mvc;

namespace DbFtw
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //Windows Auth
            filters.Add(new AuthorizeAttribute());

            //Microsoft defaults
            filters.Add(new HandleErrorAttribute());
        }
    }
}