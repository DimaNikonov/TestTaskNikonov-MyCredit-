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