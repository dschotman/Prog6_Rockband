using DependencyInjectionStarter.Library;

namespace DependencyInjectionStarter
{
    public class Keyboard : IInstrument
    {
        public string Play() {
            return "pling pling pling pling";
        }
    }
}