using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //Makes the entire site only accessible via Authorisation
            //filters.Add(new AuthorizeAttribute());
        }
    }
}
