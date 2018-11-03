using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            Orkestar orkestar = new Orkestar();
            try
            {
                orkestar.DodajInstrument(1, new Violina("Violinista Jedan")); // nestane
                orkestar.DodajInstrument(2, new Violina("Violinista Dva"));
                orkestar.DodajInstrument(11, new Kontrabas("Kontrabas-ista Jedan"));
                orkestar.DodajInstrument(12, new Kontrabas("Kontrabas-ista Dva"));
                orkestar.DodajInstrument(21, new Frula("Frulas Jedan"));
                orkestar.DodajInstrument(22, new Frula("Frulas Dva")); // nestane
                orkestar.DodajInstrument(31, new Saksofon("Saksofon-ista Jedan"));
                orkestar.DodajInstrument(32, new Saksofon("Saksofon-ista Dva"));
                orkestar.DodajInstrument(33, new Saksofon("Frulas Jedan"));

                Console.WriteLine(orkestar.Simfonija());

                orkestar.ObrisiInstrument(22);
                orkestar.ObrisiInstrument("Violinista Jedan");

                Console.WriteLine(orkestar.Simfonija());

                Instrument i = orkestar.PronadjiInstrument(31);
                Console.WriteLine(i);
                Console.WriteLine("Tip > " + i.Tip.ToString());
                Console.WriteLine("Muzicar > " + i.Muzicar + "\n");

                List<Instrument> ii = orkestar.PronadjiInstrumente("Frulas Jedan").ToList();
                foreach (var item in ii)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("Tip > " + item.Tip.ToString());
                    Console.WriteLine("Muzicar > " + item.Muzicar + "\n");
                }

                foreach (var item in typeof(InstrumentTip).GetEnumValues())
                {
                    Console.WriteLine("Instrumenata tipa {0} ima {1}", item.ToString(), orkestar.BrojInstrumenataPoTipu((InstrumentTip)item));
                }

                Console.WriteLine();
                foreach (var item in typeof(InstrumentTip).GetEnumValues())
                {
                    List<Instrument> list = orkestar.PronadjiInstrumentePoTipu((InstrumentTip)item).ToList();
                    if (list.Count > 0)
                    {
                        Console.WriteLine("Tip {0} sviraju : ", item.ToString());
                        foreach (var inst in list)
                        {
                            Console.WriteLine("Muzicar > " + inst.Muzicar);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Niko ne svira {0}", item.ToString());
                    }
                }

                Console.WriteLine();
                Type[] types = { typeof(Violina), typeof(Kontrabas), typeof(Frula), typeof(Saksofon) };
                foreach (Type x in types)
                {
                    Console.WriteLine("Broj {0} : {1}", x.Name, typeof(Orkestar).GetMethod("BrojInstrumenata").MakeGenericMethod(x).Invoke(orkestar, new object[] { }));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Desila se greska.");
                Console.WriteLine("Poruka >> " + e.Message);
                Console.WriteLine("Pracenje >> " + e.StackTrace);
            }

            Console.ReadKey(true);
        }
    }
}
