using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    class Person
    {
        //FIELDS
        private string _namn; // Skapa en Person klass. En person ska ha ett namn, en ålder, och en lista av bilar...
        private int _alder;
        public List<string> bilar;

        public Person(string namn, int alder)
        {
            _namn = namn;
            _alder = alder; 
        }

        public string namn 
        {
            get 
            {
                return _namn; 
            }
            set 
            {
                _namn = value;
            }
        }
        public int alder
        {
            get
            {
                return _alder;
            }
            set
            {
                _alder = value;
            }
        }


    }
}
