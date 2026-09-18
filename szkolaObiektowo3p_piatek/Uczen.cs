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
        private static int liczbaUczniow;
        private int nrUcznia;

        public Uczen()
        {
            
            liczbaUczniow++;
            nrUcznia = liczbaUczniow;
        }

        public Uczen(string imie, string nazwisko, int wiek) 
            : base(imie, nazwisko, wiek)
        {
            //base - wywołanie konstruktora klasy bazowej
            liczbaUczniow++;
            nrUcznia = liczbaUczniow;
        }
    }
}
