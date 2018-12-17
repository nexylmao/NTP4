using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    public class TekuciRacun : Racun
    {
        protected bool imaDozvoljeniMinus;
        protected double dozvoljeniMinus;

        public bool ImaDozvoljeniMinus { get => imaDozvoljeniMinus; }
        public double DozvoljeniMinus { get => dozvoljeniMinus; }
        public new double Stanje
        {
            get
            {
                if (imaDozvoljeniMinus)
                {
                    return stanje + dozvoljeniMinus;
                }
                else
                {
                    return stanje;
                }
            }
        }

        public TekuciRacun () : base(string.Empty, string.Empty, 0) { }

        public TekuciRacun(string ime, string prezime, double stanje, bool imaDozvoljeniMinus, double dozvoljeniMinus) : base(ime, prezime, stanje)
        {
            this.imaDozvoljeniMinus = imaDozvoljeniMinus;
            this.dozvoljeniMinus = dozvoljeniMinus;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Tekuci racun {0} : stanje racuna je {1} RSD, korisnik ", brojRacuna, stanje));
            if (imaDozvoljeniMinus)
            {
                sb.AppendLine(string.Format("ima dozvoljeni minus u iznosu od {0} RSD.", dozvoljeniMinus));
            }
            else
            {
                sb.AppendLine("nema dozvoljeni minus.");
            }
            return sb.ToString();
        }
    }
}
