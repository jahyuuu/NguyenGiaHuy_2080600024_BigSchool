using System.Web;
using System.Web.Mvc;

namespace NguyenGiaHuy_2080600024_BigSchool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
