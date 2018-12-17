using System;
using System.IO;

namespace Zadatak1
{
    class Program
    {
        private static readonly string FilePath = "NoviZahteviZaRacune.xml";

        static void PrintBanka(Banka banka)
        {
            foreach(Racun racun in banka.SviRacuniUBanci)
            {
                Console.WriteLine(racun);
            }
            Console.WriteLine("_______________________________________________________________");
        }

        static void Main(string[] args)
        {
            Banka banka = new Banka();

            DevizniRacun dr_1 = new DevizniRacun("Tinki", "Vinki", 1000, Valuta.CAD);
            TekuciRacun tr_2 = new TekuciRacun("La", "La", 20000, true, 10000);
            TekuciRacun tr_3 = new TekuciRacun("Mali", "Po", 10000, false, 0);

            int tinki, lala, po;
            banka.DodajRacun(dr_1, out tinki);
            banka.DodajRacun(tr_2, out lala);
            banka.DodajRacun(tr_3, out po);
            PrintBanka(banka);

            banka.ObrisiRacun(po);
            PrintBanka(banka);

            banka.DodajSredstvaNaRacun(tinki, 250);
            banka.DodajSredstvaNaRacun(lala, 5000);
            PrintBanka(banka);

            banka.SkiniSredstvaSaRacuna(tinki, 125);
            PrintBanka(banka);

            DevizniRacun dr_xml = new DevizniRacun("Ben", "10", 1500, Valuta.EUR);
            Console.WriteLine(dr_xml);
            TekuciRacun tr_xml = new TekuciRacun("Nine", "11", 15000, true, 5000);
            Console.WriteLine(tr_xml);

            File.Delete(FilePath);

            banka.DodajRacunUXML(dr_xml); // probably nije okay, but nema se vremena sada
            banka.DodajRacunUXML(tr_xml);

            Console.ReadKey(true);
        }
    }
}
