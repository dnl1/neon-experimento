using System.Web.Http;
using System.Web.ModelBinding;

namespace SampleRestfulAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}