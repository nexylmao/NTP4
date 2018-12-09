using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Biblioteka
{
    public class Biblioteka
    {
        private static readonly string fileName = "knjigeUNajavi.xml";

        private Dictionary<int, Knjiga> listaKnjiga;

        public Biblioteka()
        {
            listaKnjiga = new Dictionary<int, Knjiga>();
        }

        public IEnumerable<Knjiga> Knjige { get => listaKnjiga.Values; }

        public void dodajKnjigu(int key, Knjiga knjiga)
        {
            listaKnjiga.Add(key, knjiga);
        }

        public void obrisiKnjigu(int key)
        {
            listaKnjiga.Remove(key);
        }

        public IEnumerable<Knjiga> KnjigeAutora(string autor)
        {
            return listaKnjiga.Values.Where((knjiga) =>
            {
                if (knjiga.Autor == autor)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
        }

        public IEnumerable<Knjiga> KnjigeStranice(int brojStranica)
        {
            return listaKnjiga.Values.Where(knjiga =>
            {
                if (knjiga.BrojStrana >= brojStranica)
                {
                    return true;
                } 
                else
                {
                    return false;
                }
            });
        }

        public void DodajKnjiguUNajavu(IEnumerable<Knjiga> knjige)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Knjiga>));
            List<Knjiga> lista = new List<Knjiga>();
            if (File.Exists(fileName))
            {
                TextReader tr = new StreamReader(fileName);
                lista.AddRange((List<Knjiga>)xs.Deserialize(tr));
            }
            lista.AddRange(knjige);
            TextWriter tw = new StreamWriter(new FileStream(fileName, FileMode.CreateNew));
            xs.Serialize(tw, lista);
            tw.Close();
        }

        public void UcitajKnjigeIzNajave()
        {
            TextReader tw = new StreamReader(fileName);
            XmlSerializer xs = new XmlSerializer(typeof(List<Knjiga>));
            Random r = new Random(DateTime.Now.Second);
            List<Knjiga> knjige = (List<Knjiga>)xs.Deserialize(tw);
            tw.Close();
            File.Delete(fileName);
            foreach(Knjiga x in knjige)
            {
                int index = r.Next(int.MinValue, int.MaxValue);
                do
                {
                    index = r.Next(int.MinValue, int.MaxValue);
                }
                while (listaKnjiga.ContainsKey(index));
                dodajKnjigu(index, x);
            }
        }
    }
}
