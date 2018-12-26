using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestTaskNikonov.Interfaces;

namespace TestTaskNikonov.Providers
{
    public class HiProvider : IGreeter
    {
        public string SayHello()
        {
            return "Hi there!";
        }
    }
}