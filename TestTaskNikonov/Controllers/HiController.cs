using TestTaskNikonov.Interfaces;

namespace TestTaskNikonov.Controllers
{
    public class HiController : BaseController
    {     
        public HiController(IGreeter greeter):base(greeter)
        {
        }        
    }
}
