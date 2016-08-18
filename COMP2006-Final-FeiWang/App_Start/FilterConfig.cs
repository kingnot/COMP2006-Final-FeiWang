using System.Web;
using System.Web.Mvc;

namespace COMP2006_Final_FeiWang
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
