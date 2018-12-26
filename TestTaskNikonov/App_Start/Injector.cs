using System;
using System.Collections.Generic;
using System.Web.Http.Controllers;
using TestTaskNikonov.Interfaces;

namespace TestTaskNikonov.App_Start
{
    public class Injector
    {
        private static readonly Lazy<Injector> instance = new Lazy<Injector>(() => new Injector(), true);

        public static Injector Instance => instance.Value;

        private Dictionary<string, Type> controllersDictionary = new Dictionary<string, Type>();

        public void Register()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                foreach (var item in assembly.GetTypes())
                {
                    if (typeof(IHttpController).IsAssignableFrom(item) && item.IsClass)
                    {
                        var constructors = item.GetConstructors();
                        foreach (var constructor in constructors)
                        {
                            var prametrsConstructor = constructor.GetParameters();
                            foreach (var parameter in prametrsConstructor)
                            {
                                if (parameter.ParameterType.Name == nameof(IGreeter))
                                {
                                    controllersDictionary[item.Name] = item;
                                }
                            }
                        }
                    }
                }
            }
        }

        public IHttpController Resolver(string name,object[] parametrs)
        {
            return (IHttpController)Activator.CreateInstance(controllersDictionary[name],parametrs);
        }
    }
}