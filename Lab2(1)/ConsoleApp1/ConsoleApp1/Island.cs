using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Island:Planet
    {
        public void Call()
        {
            Console.WriteLine();
            Console.WriteLine("'Class Island has been called");
        }

        public void NameIslands()
        {
            var names = Enum.GetNames(typeof(Islands));

            Console.WriteLine("-----List of Islands of our Planet-----");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------");
        }

        public void NumberIslands()
        {
            var numberIslands = Enum.GetValues(typeof(Islands)).Length;
            Console.WriteLine($"Number of Islands of our Planet : {numberIslands}");
            Console.WriteLine("-----------------------------------------");
        }
    }
}
