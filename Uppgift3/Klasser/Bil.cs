using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Bil
    {
        // FIELDS
        public string _modellNamn;

        public string _model;
        public string _registreringsnummer;
        public DateTime _registrerades;
        public bool _elbil; 
        
        private double _milmatare;

        // CONSTRUCTOR till 4 bil objekten
        public Bil(string model, string registreringsnummer, DateTime registrerades, bool elbil)
        {
            _model = model;
            _registreringsnummer = registreringsnummer;
            _registrerades = registrerades;
            _elbil = elbil;
        }

        public Bil(string modellNamn) // Konstruktor till fält _modellnamn
        {
            _modellNamn = modellNamn; 
        }

        public Bil()
        {
                
        }

        public double milmatare // PROP (--> privat fält milmätare)
        {
            get
            {
                return _milmatare; 
            }
            set
            {
                _milmatare = value; 
            }
        }

        public double Stracka () 
        {
            _milmatare++; 
            return _milmatare; 
        }

        // från genomgång av uppg
        public decimal KorMil()
        {
            if (mil > 0)
            {
                _milmatare += mil; 
            }
        }
        

        // PROPERTIES   
        public string Registreringsnummer { get; set; }

        public bool Elbil { get; set; } = true; // Något som säger huruvida bilen är en elbil eller inte?

        public DateTime Registrerades // Datum för när bilen registrerades första gången?
        {
            get
            {
                return DateTime.Now;
            }
        } 

        public int Vikt { get; set; } = int.MaxValue; // Vikt i hela kilon?

        public string Model { get; set; }

    }
}
