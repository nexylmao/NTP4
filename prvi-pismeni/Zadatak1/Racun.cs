using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    public abstract class Racun
    {
        protected int brojRacuna;
        protected string ime;
        protected string prezime;
        protected double stanje;

        public int BrojRacuna { get => brojRacuna; set => brojRacuna = value; }
        public string Ime { get => ime; }
        public string Prezime { get => prezime; }
        public double Stanje { get => stanje; set => stanje = value; }

        public Racun(string ime, string prezime, double stanje)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.stanje = stanje;
            this.brojRacuna = -1;
        }
    }
}
