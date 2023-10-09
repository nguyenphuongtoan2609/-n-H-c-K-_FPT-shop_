using System.Web;
using System.Web.Mvc;

namespace Đề_Án_Học_Kỳ__TGDD_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
