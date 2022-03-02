using System.Web;
using System.Web.Mvc;

namespace Musteri_Bakiye_Seyri_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
