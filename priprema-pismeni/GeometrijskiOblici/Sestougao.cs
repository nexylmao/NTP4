using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskiOblici
{
    public class Sestougao : Objekat
    {
        private double a;

        public Sestougao(double a)
        {
            this.a = a;
        }

        public double A { get => a; set => a = value; }

        public override double IzracunajObim()
        {
            return 6 * a;
        }

        public override double IzracunajPovrsinu()
        {
            return 6 * (Math.Pow(a, 2) * Math.Sqrt(3) / 4);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sestougao {");
            sb.AppendLine("\tA : " + a);
            sb.AppendLine("\tObim : " + IzracunajObim());
            sb.AppendLine("\tPravougaonik : " + IzracunajPovrsinu());
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
