using System.Web.Http;
using TestTaskNikonov.Interfaces;

namespace TestTaskNikonov.Controllers
{
    public class BaseController : ApiController
    {
        private readonly IGreeter greeter;
        public BaseController(IGreeter greeter)
        {
            this.greeter = greeter;
        }

        public string Get() => this.greeter.SayHello();
    }
}
