using System;

namespace Klasser
{
    
    public class Fordon
    {
        public string modellnamn;
        public string registreringsnummer;
        public double matare;
        public DateTime registreringsdatum;

        public Fordon(string modellnamn, string registreringsnummer, DateTime registreringsdatum)
        {
            this.modellnamn = modellnamn;
            this.registreringsnummer = registreringsnummer;
            this.registreringsdatum = registreringsdatum; 
        }
        public Fordon()
        {

        }

        public void FordonInfo()
        {
            Console.WriteLine("Vad är det för modell på ditt fordon?");
            modellnamn = Console.ReadLine();
            Console.WriteLine("Vad är fordonets registreringsnummer?");
            registreringsnummer = Console.ReadLine();
            Console.WriteLine("När registrerades ditt fordon (yyyy-MM-dd)?");
            registreringsdatum = DateTime.Parse(Console.ReadLine());
        }
        
    }
    public class Bil : Fordon
    {
        public void SkapaBil()
        {
            bool Dragkrok = false;
            
            Console.WriteLine("Har din bil en dragkrok (ja/nej)?");
            string svarKrok = Console.ReadLine();

            if (svarKrok == "ja")
            {
                Dragkrok = true;
                Console.WriteLine("Din bil har en dragkrok");
            }
            else
            {
                Console.WriteLine("Din bil har ingen dragkrok.");
            }

        }
        public void Mil()
        {
            Console.WriteLine("Hur många mil har bilen gått?");
            int milmatare = int.Parse(Console.ReadLine());
            Console.WriteLine(milmatare + " mil");
        }
    }

    public class Motorcykel : Fordon
    {
        public void Maxfart()
        {
            Console.WriteLine("Vad motorcykelns maxfart?");
            int maxfart = int.Parse(Console.ReadLine());
            Console.WriteLine(maxfart + " km/h");
        }
    }

    public class Buss : Fordon
    {
        public void Passagerare()
        {
            Console.WriteLine("Hur många passagerare kan bussen ha?");
            int passagerare = int.Parse(Console.ReadLine());
            Console.WriteLine(passagerare + " passagerare");
        }
    }
 
    public class Lastbil : Fordon
    {
        public void Maxlast()
        {
            Console.WriteLine("Vad är lastbilens maxlast?");
            int maxlast = int.Parse(Console.ReadLine());
            Console.WriteLine(maxlast + " kg");
        }
    }
}
