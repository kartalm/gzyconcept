using System.Web.Mvc;
using System.Web.Routing;

namespace GzyConcept
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            AreaRegistration.RegisterAllAreas();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "SiteHome",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}

