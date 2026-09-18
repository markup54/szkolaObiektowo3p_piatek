using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szkolaObiektowo3p_piatek
{
    public class Uczen:Osoba

        //Uczen dziedziczy z Osoba
        //wszystkie metody i pola protected i public
        //Uczen klasa potomna
        //Osoba klasa bazowa
    {
        public static int LiczbaUczniow { get; set; }
        //pole statyczne to pole klasy a nie obiektu tej klasy
        private int nrUcznia;

        public Uczen()
        {
            imie = "XXXX";
            nazwisko = "YYYY";
            LiczbaUczniow++;
            nrUcznia = LiczbaUczniow;
        }

        public Uczen(string imie, string nazwisko, int wiek) 
            : base(imie, nazwisko, wiek)
        {
            //base - wywołanie konstruktora klasy bazowej
            LiczbaUczniow++;
            nrUcznia = LiczbaUczniow;
        }

        public override string? ToString()
        {
            return base.ToString()+" nr ucznia "+nrUcznia;
        }
    }
}
