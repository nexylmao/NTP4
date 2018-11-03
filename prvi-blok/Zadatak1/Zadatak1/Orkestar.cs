using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    public class Orkestar
    {
        protected Dictionary<int, Instrument> instrumenti;

        public Orkestar() => instrumenti = new Dictionary<int, Instrument>();

        public void DodajInstrument(int sifra, Instrument instrument) => instrumenti.Add(sifra, instrument);
        public void ObrisiInstrument(int sifra) => instrumenti.Remove(sifra);

        public void ObrisiInstrument(string muzicar)
        {
            List<int> kljucevi = new List<int>();
            foreach (var item in instrumenti)
            {
                if (item.Value.Muzicar.Equals(muzicar))
                {
                    kljucevi.Add(item.Key);
                }
            }
            if (kljucevi.Count > 0)
            {
                foreach (int kljuc in kljucevi)
                {
                    instrumenti.Remove(kljuc);
                }
            }
        }

        public Instrument PronadjiInstrument(int sifra) => instrumenti[sifra];
        public IEnumerable<Instrument> PronadjiInstrumente(string muzicar) => instrumenti.Values.ToList().FindAll(p => p.Muzicar.Equals(muzicar));

        public IEnumerable<Instrument> PronadjiInstrumentePoTipu(InstrumentTip tip) => instrumenti.Values.ToList().FindAll(p => p.Tip.Equals(tip));
        public int BrojInstrumenataPoTipu(InstrumentTip tip) => PronadjiInstrumentePoTipu(tip).Count();

        public int BrojInstrumenata<T>() where T : Instrument => instrumenti.Values.ToList().FindAll(p => p.GetType() == typeof(T)).Count;

        public string Simfonija()
        {
            StringBuilder b = new StringBuilder();
            foreach (var item in instrumenti.Values)
            {
                b.AppendLine(item.Sviraj());
            }
            return b.ToString();
        }

        internal List<Instrument> PronadjiInstrumentePoTipu(object item)
        {
            throw new NotImplementedException();
        }
    }
}
