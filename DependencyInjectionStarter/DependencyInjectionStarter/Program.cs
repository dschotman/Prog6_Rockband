using System;
using System.Collections.Generic;
using DependencyInjectionStarter.Library;

namespace DependencyInjectionStarter
{
    class Program
    {
        static void Main(string[] args) {
            List<IInstrument> MetallicaInstruments = new List<IInstrument>();
            MetallicaInstruments.Add(new Guitar());
            MetallicaInstruments.Add(new Guitar());
            MetallicaInstruments.Add(new BassGuitar());
            MetallicaInstruments.Add(new Drums());
            MetallicaInstruments.Add(new Vocal());
            var Metallica = new RockBand(MetallicaInstruments);

            List<IInstrument> ColdplayInstruments = new List<IInstrument>();

            ColdplayInstruments.Add(new Guitar());
            ColdplayInstruments.Add(new BassGuitar());
            ColdplayInstruments.Add(new Drums());
            ColdplayInstruments.Add(new Vocal());
            ColdplayInstruments.Add(new Keyboard());

            var Coldplay = new RockBand(ColdplayInstruments);

            Metallica.DoSoundCheck();
            Coldplay.DoSoundCheck();

            Console.ReadLine();
        }
    }
}