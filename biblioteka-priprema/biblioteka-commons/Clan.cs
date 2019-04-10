using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace biblioteka_commons
{
    public class Clan
    {
        private int id;
        private string ime;
        private string prezime;
        private List<int> knjige;

        [DataMember]
        public int Id => id;

        [DataMember]
        public string Ime => ime;

        [DataMember]
        public string Prezime => prezime;

        [DataMember]
        public List<int> Knjige => knjige;

        public Clan(int id, string ime, string prezime, List<int> knjige)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.knjige = knjige;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}