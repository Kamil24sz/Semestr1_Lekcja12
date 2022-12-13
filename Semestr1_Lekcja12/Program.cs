using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1_Lekcja12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Stworzyć tablicę imion  OK
            //2.Wylosować osobę z tej tablicy  OK
            //3.Wypisać wylosowaną osobę.

            string[] uczniowie = { "Kamil M", "Bartek B", "Kasia K", "Aleksandra K", "Karol P" };

            //do losowania
            Random r = new Random();


            int wylosowanyIndeks = r.Next(0, uczniowie.Length);

            Console.WriteLine("Do odpowiedzi został/a wybrany/a " + uczniowie[wylosowanyIndeks]);


            //METODY
            double wynik = Math.Pow(2,5);

            //liczienie "na piechotę"
            double wynik2 = 2;
            for(int i = 1; i <= 5; i++)
            {
                wynik2 = wynik2 * 2;
            }

            //Wywołanie metody + wypisanie wyniku metody
            Console.WriteLine(Dodawanie(5, 7));
            Console.WriteLine(Odejmowanie(15, 25));
            Console.WriteLine(Mnozenie(2.5, 13));
            Console.WriteLine(Dzielenie(2.5, 13));
            Console.WriteLine("Pole trapezu wynosi: " + ObliczaniePolaTrapezu(10, 15, 5));
            Console.WriteLine("Pole trapezu2 wynosi: " + ObliczaniePolaTrapezu(2.67, 3.28, 5.14));
            Console.WriteLine("Pola trojkata wynosi: " + ObliczaniePolaTrojkataRownobocznego(2.56));
            Console.WriteLine("Pole trojkata2 wynosi: " + ObliczaniePolaTrojkataRownobocznego2(10));
            Powitanie("Kamil");

            Console.ReadLine();
        }
        //Deklaracja metody
        public static int Dodawanie(int liczba1, int liczba2)
        {
            return liczba1 + liczba2;
        }
        public static int Odejmowanie(int a, int b)
        {
            int wynik = a - b;
            return wynik;
        }
        public static double Mnozenie(double a, double b)
        {
            return a * b;
        }
        public static double Dzielenie(double a, double b)
        {
            return a / b;
        }
        public static double ObliczaniePolaTrapezu(double a, double b, double h)
        {
            double wynik =  (a + b) * h / 2;
            return wynik;
        }
        public static double ObliczaniePolaTrojkataRownobocznego(double a)
        {
            // a^2 * pierwiastek(3) / 4 
            double wynik = Math.Pow(a, 2) * Math.Sqrt(3) / 4;
            return wynik;
        }
        public static string ObliczaniePolaTrojkataRownobocznego2(double a)
        {
            double wynik = Math.Pow(a, 2) / 4;
            return wynik.ToString() + "(pierwiastków z 3)";
        }
        //WYJĄTKOWA METODA, KTÓRA NIC NIE ZWRACA => VOID
        public static void Powitanie(string name)
        {
            Console.WriteLine("Witam Cię " + name);
        }
    }
}
