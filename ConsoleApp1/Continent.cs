using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    enum Continents
    {
        Europe, Asia, Africa, Australia, Antarctica, America
    }
    class Continent
    {
        public void Call()
        {
            Console.WriteLine("'Class Continent has been called'");
            Console.WriteLine();
        }

        public void NameContinents()
        {
          var names= Enum.GetNames(typeof(Continents));

            Console.WriteLine("-----List of Continents of our Planet-----");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------");
        }

        public void NumberContinents()
        {
            var numberContinents = Enum.GetValues(typeof(Continents)).Length;
            Console.WriteLine($"Number of Continents of our Planet : {numberContinents}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
        }
    }
}
