using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskiOblici
{
    public class Pravougaonik : Objekat
    {
        private double a, b;

        public Pravougaonik(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double A { get => a; }
        public double B { get => b; }

        public override double IzracunajObim()
        {
            return 2 * (a + b);
        }

        public override double IzracunajPovrsinu()
        {
            return a * b;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Pravougaonik {");
            sb.AppendLine("\tA : " + a);
            sb.AppendLine("\tB : " + b);
            sb.AppendLine("\tObim : " + IzracunajObim());
            sb.AppendLine("\tPravougaonik : " + IzracunajPovrsinu());
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
