using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
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
