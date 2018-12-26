using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestTaskNikonov.Interfaces;

namespace TestTaskNikonov.Providers
{
    public class HelloProvider : IGreeter
    {
        public string SayHello()
        {
            return "Hi everyone!";
        }
    }
}