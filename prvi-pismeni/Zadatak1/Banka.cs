using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Zadatak1
{
    public class Banka
    {
        private static readonly string FilePath = "NoviZahteviZaRacune.xml";

        protected Dictionary<int, Racun> racuni;

        public Banka()
        {
            racuni = new Dictionary<int, Racun>();
        }

        public IEnumerable<Racun> SviRacuniUBanci { get => racuni.Values; }

        public void DodajRacun(Racun racun, out int brojRacuna)
        {
            if (racuni.Values.Contains(racun))
            {
                throw new Exception("Racun vec postoji.");
            }
            Random r = new Random(DateTime.Now.Millisecond);
            int newKey = 0;
            do
            {
                newKey = r.Next(0, int.MaxValue);
            }
            while (racuni.ContainsKey(newKey));
            racuni.Add(newKey, racun);
            racun.BrojRacuna = newKey;
            brojRacuna = newKey;
        }

        public bool ObrisiRacun(int brojRacuna)
        {
            if (racuni.ContainsKey(brojRacuna))
            {
                racuni.Remove(brojRacuna);
                return true;
            }
            return false;
        }

        public bool DodajSredstvaNaRacun(int brojRacuna, double suma)
        {
            if (racuni.ContainsKey(brojRacuna))
            {
                racuni[brojRacuna].Stanje += suma;
                return true;
            }
            return false;
        }

        public bool SkiniSredstvaSaRacuna(int brojRacuna, double suma)
        {
            if (racuni.ContainsKey(brojRacuna))
            {
                Racun racun = racuni[brojRacuna];
                if (racun.Stanje >= suma)
                {
                    racun.Stanje -= suma;
                    return true;
                }
                return false;
            }
            return false;
        }

        public void DodajRacunUXML(Racun racun)
        {
            TextWriter tw = new StreamWriter(new FileStream(FilePath, FileMode.Append));
            XmlSerializer xs = new XmlSerializer(racun.GetType());
            xs.Serialize(tw, racun);
            tw.Close();
        }
    }
}
