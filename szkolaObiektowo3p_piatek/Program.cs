// See https://aka.ms/new-console-template for more information
using szkolaObiektowo3p_piatek;

Console.WriteLine("Hello, World!");


//klasa Osoba 
//w JAvie każda klasa w oddzielnym pliku tu może być w jednym
//testowanie klasy osoba
//modyfikatory dostępu
//pola metody konstruktor

Osoba osoba = new Osoba();//wywołanie konstruktora
//nowy obiekt klasy Osoba
/*
 * niedostępne dla pól prywatnych 
 * można tylko na publicznych
 * osoba.imie = "Jaś";
osoba.nazwisko = "Muchomorek";
osoba.wiek = 12;
Console.WriteLine("imię: "+osoba.imie);*/
Console.WriteLine(osoba);

Osoba osoba2 = new Osoba("Ala","Jarzębinka",10);//wywołanie konstruktora
Console.WriteLine(osoba2);
//Console.WriteLine(osoba2.imie);

