using System.Web;
using System.Web.Mvc;

namespace Tuan7_PhamHongPhong
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
