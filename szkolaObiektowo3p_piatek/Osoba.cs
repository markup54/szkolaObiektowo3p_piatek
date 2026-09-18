using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szkolaObiektowo3p_piatek
{
    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private int wiek;

        public Osoba()
        {
        }

        public Osoba(string imie, string nazwisko, int wiek)
        {
            //this.imie - pole klasy
            //imie - zmienna lokalna w tej metodzie
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }

        public override string? ToString()
        {
            return "imię: "+imie+"\n nazwisko: "+nazwisko;
        }
    }
}
