using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp18._2
{
    class Dier
    {
        private string _naam;

        public string Eten()
        {
            return "";
        }
        public string Praten(string zin)
        {
            return "";
        }
        public string Strelen()
        {
            return "";
        }
        protected Dier(string name)
        {
            _naam = name;
        }
        protected string Naam
        {
            get => _naam;
        }
    }

    class Mens : Dier
    {
        public string Eten()
        {
            return "Lekker! ";
        }
        public Mens(string name) : base(name)
        {

        }
        public string Praten(string zin)
        {
            if (zin == "Hoe gaat het? ")
                return "Goed en met U? ";
            else if (zin == "Hoe heet jij? ")
                return "Ik heet Paulo";
            else return "Ook een goede morgen. ";
        }
        public string Strelen()
        {
            return "Blijf van mijn lijf. Arrh. ";
        }
    }
    class Papegaai : Dier
    {
        public Papegaai(string name) : base(name)
        {

        }
        public string Praten(string zin)
        {
            Random mijnRandom = new Random();
            int Geluk = mijnRandom.Next(1, 101);
            if (Geluk <= 20)
            {
                return "Koko kopke krabben. ";
            }
            else
            {
                return zin;
            }

        }
        public string Strelen()
        {
            return "Koko ";
        }
    }
    class Kat : Dier
    {
        private int _teller;
        public Kat(string name) : base(name)
        {

        }
        public string Praten(string Zin)
        {
            _teller++;
            if (_teller % 3 == 0)
            {
                return "Miaauw ";
            }
            return "";
        }
        public string Strelen()
        {
            return "RrRr. ";
        }
    }
}
