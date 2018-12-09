using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Knjiga k1 = new Knjiga("SundjerBob", "KockaLone", new DateTime(2000, 8, 19), 25);
            Knjiga k2 = new Knjiga("Patrik", "Zvezda", new DateTime(1999, 10, 11), 40);
            Knjiga k3 = new Knjiga("Lignjoslav", "Debil", new DateTime(1959, 11, 9), 56);
            Knjiga k4 = new Knjiga("Sendi", "Vever'ca", new DateTime(2000, 1, 2), 120);

            Biblioteka biblioteka = new Biblioteka();
            biblioteka.dodajKnjigu(1, k1);
            biblioteka.dodajKnjigu(2, k2);
            biblioteka.dodajKnjigu(3, k3);
            biblioteka.dodajKnjigu(4, k4);

            biblioteka.UcitajKnjigeIzNajave();

            foreach(Knjiga x in biblioteka.Knjige)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey(true);
        }
    }
}
