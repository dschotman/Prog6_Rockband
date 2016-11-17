using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionStarter.Library
{
    public class RockBand
    {
        private List<IInstrument> _instruments;

        public RockBand(List<IInstrument> instruments) {
            this._instruments = instruments;
        }

        public void DoSoundCheck() {
            _instruments.ForEach(i => Console.WriteLine(i.Play()));
            Console.WriteLine();
        }
    }
}