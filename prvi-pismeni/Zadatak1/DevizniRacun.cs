using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    public enum Valuta { EUR, USD, CAD, AUS, CHF }

    public class DevizniRacun : Racun
    {
        protected Valuta valuta;

        public Valuta Valuta { get => valuta; }

        public DevizniRacun() : base(string.Empty, string.Empty, 0) { }

        public DevizniRacun(string ime, string prezime, double stanje, Valuta valuta) : base(ime, prezime, stanje)
        {
            this.valuta = valuta;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Devizni racun {0} : stanje racuna je {1} {2}.", brojRacuna, stanje, valuta.ToString()));
            return sb.ToString();
        }
    }
}
