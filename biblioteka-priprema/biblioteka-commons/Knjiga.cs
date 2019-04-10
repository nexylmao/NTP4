using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace biblioteka_commons
{
    [DataContract]
    public class Knjiga
    {
        private int id;
        private string ime;
        private string autor;
        private int godinaIzdavanja;
        private int brojnoStanje;
        
        [DataMember]
        public int Id => id;

        [DataMember]
        public string Ime => ime;

        [DataMember]
        public string Autor => autor;

        [DataMember]
        public int GodinaIzdavanja => godinaIzdavanja;

        [DataMember]
        public int BrojnoStanje => brojnoStanje;

        public Knjiga(int id, string ime, string autor, int godinaIzdavanja, int brojnoStanje)
        {
            this.id = id;
            this.ime = ime;
            this.autor = autor;
            this.godinaIzdavanja = godinaIzdavanja;
            this.brojnoStanje = brojnoStanje;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}