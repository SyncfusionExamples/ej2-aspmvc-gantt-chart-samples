using System.Web;
using System.Web.Mvc;

namespace OdataV4Adaptor.client
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
