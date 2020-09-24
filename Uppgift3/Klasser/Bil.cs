using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Bil
    {
        public string Registreringsnummer { get; set; }

        public bool Elbil { get; set; }

        public DateTime Registrerades { get; set; }

        public int Vikt { get; set; }

        public string Model { get; set; }





        public Bil()
        {
            
            Registreringsnummer = "Abc 123";
            Elbil = true;
            Registrerades = DateTime.Now;
            Vikt = 100; 
            Model = "BMW Z3"; 

        }
    }



}
