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