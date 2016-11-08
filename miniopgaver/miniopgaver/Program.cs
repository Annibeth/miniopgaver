using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniopgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave1();
            // Opgave2();
            // Opgave3();
            // Opgave4();
            // Opgave5();
            Opgave6();

        }
        public static void Opgave1()
        {
            // opgave 1 starter her :-)
            Console.WriteLine("hello");
            Console.WriteLine("Annibeth");
            Console.ReadKey();
        }
        public static void Opgave2()
        {
            // opgave 2
            int tal1 = 12; int tal2 = 13; int resultat = tal1 + tal2;

            Console.WriteLine(tal1 + " + " + tal2 + " Er lig med =");
            Console.WriteLine(resultat);
            Console.ReadKey();

        }
        public static void Opgave3()
        {
            // opgave 3
            int tal1 = 24; int tal2 = 5; int resultat = tal1 / tal2;

            Console.WriteLine(tal1 + " / " + tal2 + " Er lig med =");
            Console.WriteLine(resultat);
            Console.ReadKey();

        }
        public static void Opgave4()
        {
            // opgave 4
            // brug float !
            int resultat1 =  (-1 + 3) * 5;
            int resultat2 = (24 + 5) % 7;
            int resultat3 = 15 + -4*6 / 11;
            int resultat4 = 2 + 10 / 6 * 1 - 7 % 2;

            // skriv
            Console.WriteLine("Resultatet af -1 + 3 * 5 = " + resultat1);
            Console.WriteLine("Resten af 24 + 5 / 7 er = " + resultat2);
            Console.WriteLine("Resultatet af 15 + -4*6 / 11 er = " + resultat3);
            Console.WriteLine("Resten af 2 + 10 / 6 * 1 - 7 % 2 er = " + resultat4);
            Console.ReadKey();
        }
        public static void Opgave5()
        {
            //Opgave 5
            int tal1, tal2, Sum;
            Console.WriteLine("Skriv et tal: ");
            tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv et andet tal: ");
            tal2 = int.Parse(Console.ReadLine());
            Sum = tal1 + tal2;
            Console.WriteLine("Summen af tal1 + det andet tal er = " + Sum);
            Console.ReadKey();
        }
        public static void Opgave6()
        {
            //Opgave 6
            int tal1, tal2, tal3, Sum;
            Console.WriteLine("my name is Annibeth Stroemsten");
            Console.WriteLine("Skriv et tal: ");
            tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv et andet tal: ");
            tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv et tredie tal: ");
            tal3 = int.Parse(Console.ReadLine());
            Sum = tal1 * tal2 * tal3;
            Console.WriteLine("Summen af tal1 * det andet tal * det tredie tal er = " + Sum);
            Console.ReadKey();
        }
    }
}
