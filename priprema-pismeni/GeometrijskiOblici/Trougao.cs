using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskiOblici
{
    public class Trougao : Objekat
    {
        private double a;

        public Trougao(double a)
        {
            this.a = a;
        }

        public double A { get => a; }

        public override double IzracunajObim()
        {
            return 3 * a;
        }

        public override double IzracunajPovrsinu()
        {
            return (Math.Pow(a, 2) * Math.Sqrt(3)) / 4;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Trougao {");
            sb.AppendLine("\tA : " + a);
            sb.AppendLine("\tObim : " + IzracunajObim());
            sb.AppendLine("\tPravougaonik : " + IzracunajPovrsinu());
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
