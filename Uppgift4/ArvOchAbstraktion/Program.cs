using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Klasser;


namespace ArvOchAbstraktion
{
    public interface IVerkstad
    {
        void AddFordon(Fordon fordon);
        void RemoveFordon(Fordon fordon);

    }
    public class Verkstad : IVerkstad
    {
        List<Fordon> _fordon = new List<Fordon>();

        public Verkstad()
        {

        }
        public void AddFordon(Fordon fordon)
        {
            _fordon.Add(fordon);
            Console.WriteLine("Ditt fordon kan nu lämnas in i verkstad.");
        }

        public void RemoveFordon(Fordon fordon)
        {
            _fordon.Remove(fordon);
            Console.WriteLine("Ett fordon är klar. Ditt fordon kan köras in.");
        }
    }
    class VerkstadV2 : IVerkstad
    {
        public void AddFordon(Fordon fordon)
        {

        }

        public void RemoveFordon(Fordon fordon)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fordon fordon = new Fordon();
            Bil bil = new Bil();
            Motorcykel motorcykel = new Motorcykel();
            Buss buss = new Buss();
            Lastbil lastbil = new Lastbil();

            Console.WriteLine("Vad har du för fordon? " +
                            "\nVälj alternativ 1-4 " +
                            "\n[1] Bil " +
                            "\n[2] Motorcykel " +
                            "\n[3] Buss " +
                            "\n[4] Lastbil");

            int fordonVal = int.Parse(Console.ReadLine());

            switch (fordonVal)
            {
                case 1:
                    Console.WriteLine("Du har en bil");
                    break;
                case 2:
                    Console.WriteLine("Du har en motorcykel");
                    break;
                case 3:
                    Console.WriteLine("Du har en buss");
                    break;
                case 4:
                    Console.WriteLine("Du har en lastbil");
                    break;
                default:
                    Console.WriteLine("Vi kan inte ta emot ditt fordon i verkstad");
                    break;
            }

            if (fordonVal == 1)
            {
                fordon.FordonInfo();
                bil.SkapaBil();
                bil.Mil();
            }
            else if (fordonVal == 2)
            {
                fordon.FordonInfo();
                motorcykel.Maxfart(); 
            }
            else if (fordonVal == 3)
            {
                fordon.FordonInfo();
                buss.Passagerare();
            }
            else if (fordonVal == 4)
            {
                fordon.FordonInfo();
                lastbil.Maxlast();
            }

            Console.ReadKey();

            Console.WriteLine("------------------------------------------------");

            IVerkstad verkstad = new Verkstad();

            Console.WriteLine("Verkstad är full. \nNär ett fordon är klar, så kan ditt fordon köras in.");
            Console.WriteLine("Kan du vänta (ja/nej)?");
            string svar = Console.ReadLine();

            if (svar == "ja")
            {
                verkstad.RemoveFordon(fordon);
            }
            else
            {
                verkstad.AddFordon(fordon);
            }

            Console.ReadKey();
        }
    }
  
}
