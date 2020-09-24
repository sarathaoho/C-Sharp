using System;
using System.Security.Cryptography.X509Certificates;

namespace Villkor_och_loopar
{

    /// <summary>


    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            
            int startnummer = 0;
           
            int startTimme = 0;
            int startMinut = 0;
            int startSekund = 0;
            int malTimme = 0;
            int malMinut = 0;
            int malSekund = 0;

            int antalTavlande = 0;
            int vinnarNummer = 0;
            int bastaTid = int.MaxValue;

            int startTimmeSek = 0,
                startMinutSek = 0,
                malTimmeSek = 0,
                malMinutSek = 0;

            int startTidSekunder = 0;
            int malTidSekunder = 0;
            int totalSlutSekunder = 0; 

            int slutTimme = 0,
                slutMinut = 0,
                slutSekund = 0;

            while (true)
            {

                Console.WriteLine("Ange startnummer: ");
                startnummer = Convert.ToInt32(Console.ReadLine());

                if (startnummer < 1)
                {

                    break;

                }

                //starttid
                Console.WriteLine("Ange timme för start: ");
                startTimme = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ange minut för start: ");
                startMinut = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ange sekund för start: ");
                startSekund = Convert.ToInt32(Console.ReadLine());

                //måltid
                Console.WriteLine("Ange timme för mål");
                malTimme = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ange minut för mål");
                malMinut = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ange sekund för mål");
                malSekund = Convert.ToInt32(Console.ReadLine());

                antalTavlande++;

                // omvandlar timmma och minut til sekunder
                startTimmeSek = startTimme * 3600; // tim till sek
                startMinutSek = startMinut * 60; // minut till sek
                malTimmeSek = malTimme * 3600;
                malMinutSek = malMinut * 60;

                // START tiden & MÅL tiden i sekunder (timme + minuter + sekunder)
                malTidSekunder = (malTimmeSek + malMinutSek + malSekund);
                startTidSekunder = (startTimmeSek + startMinutSek + startSekund);

                // Om tiden passerar midnatt
                if (startTidSekunder > malTimme)
                {

                    malTidSekunder += 86400;

                }

                totalSlutSekunder = malTidSekunder - startTidSekunder;

                // Bästa vinnartiden (kortast tid mellan start och mål)
                if (totalSlutSekunder < bastaTid)
                {

                    bastaTid = totalSlutSekunder;
                    vinnarNummer = startnummer;

                }

            } // slutet av while loop blocket


                // KODEN FUNKAR EJ NÄR ORDNINGEN ÄNDRAS
                //slutTimme = totalSlutSekunder / 3600;
                //slutMinut = (totalSlutSekunder % 3600) / 60;
                //slutSekund = (totalSlutSekunder % 3600) % 60;

                Console.WriteLine($"Startnummer {vinnarNummer} är vinnaren");
                Console.WriteLine($"Vinnande sluttid: {slutTimme} timmar, {slutMinut} minuter, {slutSekund} sekunder.");
                Console.WriteLine($"Antal tävlande: {antalTavlande}");


            Console.ReadKey();
            
        
        }
    }
}
