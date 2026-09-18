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
        /*
         * modyfikatory dostępu
         * private - pola dostępne tylko w tej klasie
         * protected - pola dostępne w tej klasie i klasach dziedziczących
         * public - ogólnodostępne
         * stosowanie hermetyzacji wymaga pól i metod prywatnych lub chronionych
         * hermetyzacja  == enkapsulacja
         * żeby się dostąc do prywatnych pól należy stosować metody dostępowe
         * 
         */

        public Osoba()
        {
        }
        //dwa konstruktory/metody o takich samych nazwach ale różnych
        //parametrach to przeciążanie
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
