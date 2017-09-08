using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using System.Web.Optimization;

namespace YoungNeedlesGames
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //Enabling Bundling and Minification
            BundleTable.EnableOptimizations = false;
            BundleConfig.RegisterBundles(BundleTable.Bundles);
		}
    }
}
