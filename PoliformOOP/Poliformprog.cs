using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliformOOP
{
    class Poliformprog
    {
        static void Main(string[] args)
        {
        }
    }
    class Ember
    {
        public string Nev { set; get; }

        private string bemut = "Üdvözlöm, a nevem";
        public Ember(string nev)
        {
            Nev = nev;
        }
        public string beszel()
        {
            return (bemut + Nev);
        }

    }

    class Ferfi : Ember
    {
        public int Kor { set; get; }
        public Ferfi(string nev, int kor) : base(nev)
        {
            Kor = kor;
        }
    }
    class Woman : Ember
    {
        public int Szemszín { set; get; }
        public Woman(string nev, int szemszin) : base(nev)
        {
            Szemszín = szemszin;
        }
    }
    class Haz
    {
        private List<Ember> lakok = new List<Ember>();
        public void hazajon(Ember obj)
        {
            this.lakok.Add(obj);

        }
        public void csenget()
        {
            int i;
            Random rd = new Random();
            if (lakok.Count > 0)
            {
                i = rd.Next(0, lakok.Count - 1);
                Console.WriteLine(lakok[i].beszel());
            }
        }
    }
}

