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
            // BIL OBJEKT 1
            Bil bil1 = new Bil("BMW", "Abc 123", DateTime.Now, true);
            //bil1.Model = "BMW";
            //bil1.Registreringsnummer = "Abc 123";
            //bil1.Registrerades = DateTime.Now;
            //bil1.Elbil = true;

            // BIL OBJEKT 2
            Bil bil2 = new Bil("Volvo", "AAA 111", DateTime.Now, true);

            // BIL OBJEKT 3
            Bil bil3 = new Bil("Honda", "BBB 222", DateTime.Now, false);

            // BIL OBJEKT 4
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

                if (elbilar[i] == true) //(ebilar[i])
                {
                    Console.WriteLine("Detta är en elbil!");
                }

                Console.WriteLine("-----------------------------------");
                
                i++; 
            }

            Console.WriteLine();

            //Bil milen = new Bil();
            //milen.milmatare = 1000;    
            //Console.WriteLine("Bilens mil är " + milen.Stracka().ToString());

            //Console.WriteLine( );

            //Bil forstaRegistrering = new Bil();
            //Console.WriteLine("Första gången bilen registrerades var den " + forstaRegistrering.Registrerades);

            //Console.WriteLine();

            //Console.WriteLine("--------------------------------------------------------------");

            //Console.WriteLine();
            
            //// OBJEKT PERSON 1
            //Person person1 = new Person("Per", 35);
            //Console.WriteLine($"Ditt namn: {person1.namn}");
            //Console.WriteLine($"Din ålder: {person1.alder}");
            
            //Console.WriteLine("Hur många bilar har du?");
            //int input = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //// OBJEKT PERSON 2
            //Person person2 = new Person("Anna", 25);
            //Console.WriteLine($"Ditt namn: {person2.namn}");
            //Console.WriteLine($"Din ålder: {person2.alder}");

            ////ANNA BIL INFO (PERS 2)
            //Bil anna = new Bil();
            //var datum = new DateTime();
            
            //Console.WriteLine("Fyll i informationen om din/dina bilar;");
            //Console.WriteLine("Model: "); string model = Console.ReadLine();
            //Console.WriteLine("Bilens registreringsnummer: "); int registreringsnummer = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bilens registreringsdag (yy-MM-dd): "); string registrerades = (Console.ReadLine());
            //int input2 = int.Parse(Console.ReadLine());



            //List<Person> bilar = new List<Person>(2);
            //bilar.Add(person1);
            //bilar.Add(person2);
            ////foreach (Person bil in bilar)
            ////{
            ////    Console.WriteLine(bilar);
            ////}


            Console.ReadLine(); 
        }
    }


}