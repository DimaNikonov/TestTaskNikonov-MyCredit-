using System.Web.Http;
using System.Web.Http.Dispatcher;
using TestTaskNikonov.App_Start;
using TestTaskNikonov.Controllers;

namespace TestTaskNikonov
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Injector.Instance.Register();

            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator), new ControllerActivator());
        }
    }
}
