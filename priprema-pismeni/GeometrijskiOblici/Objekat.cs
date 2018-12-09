using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskiOblici
{
    public abstract class Objekat
    {
        private static int instances = 0;

        public Objekat() => instances++;

        public static int Instances { get => instances; }

        public abstract double IzracunajObim();
        public abstract double IzracunajPovrsinu();
    }
}
