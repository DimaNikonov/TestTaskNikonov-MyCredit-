using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using TestTaskNikonov.Providers;

namespace TestTaskNikonov.Controllers
{
    public class ControllerActivator : IHttpControllerActivator
    {
        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            IHttpController controller ;
            switch (controllerType.Name)
            {
                case nameof(HiController):
                    controller = new HiController(new HiProvider());
                    break;
                case nameof(HelloController):
                    controller = new HelloController(new HelloProvider());
                    break;
                default:
                    controller = null;
                    break;
            }
            return controller;
        }
    }
}