using TestTaskNikonov.Interfaces;

namespace TestTaskNikonov.Controllers
{
    public class HelloController : BaseController
    {
        public HelloController(IGreeter greeter) : base(greeter)
        {
        }
    }
}