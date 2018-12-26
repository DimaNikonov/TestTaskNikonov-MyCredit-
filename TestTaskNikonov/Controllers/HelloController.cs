using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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