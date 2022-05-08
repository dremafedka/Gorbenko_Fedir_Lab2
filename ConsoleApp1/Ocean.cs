using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    enum Oceans
    {
        Arctic, Atlantic, Pacific, Indian
    }
    class Ocean
    {
        public void Call()
        {
            Console.WriteLine("'Class Oceans has been called'");
            Console.WriteLine();
        }

        public void NameOceans()
        {
            var names = Enum.GetNames(typeof(Oceans));

            Console.WriteLine("-----List of Oceans of our Planet-----");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------");
        }

        public void NumberOceans()
        {
            var numberOceans = Enum.GetValues(typeof(Oceans)).Length;
            Console.WriteLine($"Number of Oceans of our Planet : {numberOceans}");
            Console.WriteLine("-----------------------------------------");
        }
    }
}
