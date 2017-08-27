using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationNyFerie
{
    class Class1
    {
        public int Alder { get; set; }
        public string Navn { get; set; }
        public DateTime Dato { get; set; }

        public Class1()
        {
            Alder = 1;
            Navn = "John Doe";
            Dato = DateTime.Today;
        }

        public Class1(int alder, string navn)
        {
            Alder = alder;
            Navn = navn;
            Dato = DateTime.Today;
        }
        public string Person(Class1 personer)
        {
            string navnet = personer.Navn;
            string alder = " er " + personer.Alder + " år gamle";
            string personen = navnet + alder + " Den " + personer.Dato;
            return personen;
        }
        
    }
}
