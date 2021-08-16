using RestaurantSystem.Helper;
using RestaurantSystem.Models;
using System.Web;
using System.Web.Mvc;

namespace RestaurantSystem
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomAuthenticationAttribute());
        }
    }
}
