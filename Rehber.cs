using System;
using System.Collections.Generic;
using System.Text;

namespace Telefon_Rehberi
{
    public class Rehber
    {
        public Rehber()
        {

        }
        public Rehber(string name, string number, string surname)
        {
            Name = name;
            Number = number;
            Surname = surname;
        }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Surname {get; set;}
    }
}
