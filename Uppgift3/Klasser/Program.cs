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
            Bil bil1 = new Bil("BMW", "Abc 123", DateTime.Now, true);
            //bil1.Model = "BMW";
            //bil1.Registreringsnummer = "Abc 123";
            //bil1.Registrerades = DateTime.Now;
            //bil1.Elbil = true;

            // OBJEKT 2
            Bil bil2 = new Bil("Volvo", "AAA 111", DateTime.Now, true);

            // OBJEKT 3
            Bil bil3 = new Bil("Honda", "BBB 222", DateTime.Now, false);

            // OBJEKT 4
            Bil bil4 = new Bil("Toyota", "CCC 333", DateTime.Now, false);

            //ARRAY
            string[] modeller = new string[4] {"BMW", "Volvo", "Honda", "Toyota" };
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

            Console.WriteLine();

            Bil milen = new Bil();
            milen.milmatare = 1000;    
            Console.WriteLine("Bilens mil är " + milen.Stracka().ToString());

            Console.WriteLine( );

            Bil forstaRegistrering = new Bil();
            Console.WriteLine("Första gången bilen registrerades var den " + forstaRegistrering.Registrerades);



            Console.ReadLine(); 
        }
    }


}