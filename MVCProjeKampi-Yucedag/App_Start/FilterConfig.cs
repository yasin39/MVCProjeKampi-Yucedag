using System.Web;
using System.Web.Mvc;

namespace MVCProjeKampi_Yucedag
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
