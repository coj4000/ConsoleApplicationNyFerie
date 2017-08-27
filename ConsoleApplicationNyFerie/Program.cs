using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationNyFerie
{
    class Program
    {
        static void ElevWork()
        {
            List<Class1> listeClass = new List<Class1>();
            Class1 nyElev = new Class1(22, "Frank");
            Class1 nyElev1 = new Class1(23, "John");
            listeClass.Add(nyElev);
            listeClass.Add(nyElev1);
            
            foreach (var person in listeClass)
            {
                if (person.Alder <= 22)
                {
                    person.Navn = "1.års elev " + person.Navn;
                }
                else if (person.Alder >= 23)
                {
                    person.Navn = "2.års elev " + person.Navn;
                }
                string elev = person.Person(person);
                
                Console.WriteLine($"Denne {elev}");
            }

        }

        static void Main(string[] args)
        {
            try
            {
                ElevWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;

            }
        }
    }
}
