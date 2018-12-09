using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskiOblici
{
    class Program
    {
        static void Main(string[] args)
        {
            Trougao t = new Trougao(3);
            Pravougaonik p = new Pravougaonik(3, 4);
            Sestougao s = new Sestougao(4);

            Console.WriteLine(t);
            Console.WriteLine(p);
            Console.WriteLine(s);

            Console.WriteLine("Instance count : " + Objekat.Instances);
            Console.ReadKey(true);
        }
    }
}
