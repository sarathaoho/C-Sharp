using System;
using System.Collections.Generic;

namespace Klasser
{
    class Program
    {
        /// <summary>
        /// Se instruktionenr i Uppgift.txt
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // OBJEKT 1
            Bil bil1 = new Bil();
            bil1.Model = "BMW Z3";
            bil1.Registreringsnummer = "Abc 123";
            bil1.Registrerades = DateTime.Now;
            bil1.Elbil = true;

            // OBJEKT 2
            Bil bil2 = new Bil();
            bil2.Model = "Volvo Z3";
            bil2.Registreringsnummer = "AAA 111";
            bil2.Registrerades = DateTime.Now;
            bil2.Elbil = true;

            // OBJEKT 3
            Bil bil3 = new Bil();
            bil3.Model = "Honda Z3";
            bil3.Registreringsnummer = "BBB 222";
            bil3.Registrerades = DateTime.Now;
            bil3.Elbil = false;

            // OBJEKT 4
            Bil bil4 = new Bil();
            bil4.Model = "Toyota Z3";
            bil4.Registreringsnummer = "CCC 333";
            bil4.Registrerades = DateTime.Now;
            bil4.Elbil = false;

            //ARRAY
            string[] modeller = new string[4] {"BMW Z3", "Volvo Z3", "Honda Z3", "Toyota Z3" };
            string[] allaRegistreringsnummer = new string[4] {"Abc 123", "AAA 111", "BBB 222", "CCC 333" };
            DateTime[] narRegistrerades = new DateTime[4] {DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now };
            bool[] elbilar = new bool[4] {true, true, false, false};

            // LOOP
            int i = 0;
            while (i < 4)
            {

                Console.WriteLine("Modell: " + modeller[i]);
                Console.WriteLine("Registreringsnummer: " + allaRegistreringsnummer[i]);
                Console.WriteLine("Registrerades: " + narRegistrerades[i]);

                if (elbilar[i] == true)
                {
                    Console.WriteLine("Detta är en elbil!");
                }

                Console.WriteLine("-----------------------------------");
                
                i++; 
            }

            Console.ReadLine(); 
        }
    }


}