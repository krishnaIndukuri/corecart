using Microsoft.Extensions.Configuration;

namespace corecart
{
    public interface IGreeting
    {
         string getGreetings();
    }
    public class Greeting : IGreeting
    {
        private IConfiguration _configuration;

        public Greeting(IConfiguration config)
        {
            _configuration = config;
        }
        public string getGreetings()
        {
            return _configuration["Greetings"];
        }
    }
}