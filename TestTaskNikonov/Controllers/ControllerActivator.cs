using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using TestTaskNikonov.App_Start;
using TestTaskNikonov.Interfaces;
using TestTaskNikonov.Providers;

namespace TestTaskNikonov.Controllers
{
    public class ControllerActivator : IHttpControllerActivator
    {
        private string controller = "Controller";

        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            Type providerStartWith = null;
            var providers = this.GetProviders();
            string nameConttroller = controllerType.Name;
            if (nameConttroller.EndsWith(controller))
            {
                var startWith = nameConttroller.Remove(
                    nameConttroller.IndexOf(controller));
                foreach (var provider in providers)
                {
                    if (provider.Name.StartsWith(startWith))
                    {
                        providerStartWith = provider;
                    }
                }
            }

            return Injector.Instance.Resolver(controllerType.Name, new object[] { (IGreeter)Activator.CreateInstance(providerStartWith) });
        }

        private IEnumerable<Type> GetProviders()
        {
            List<Type> providers = new List<Type>();

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                foreach (var type in assembly.GetTypes())
                {
                    if (typeof(IGreeter).IsAssignableFrom(type) && type.IsClass)
                    {
                        providers.Add(type);
                    }
                }
            }

            return providers;
        }
    }
}