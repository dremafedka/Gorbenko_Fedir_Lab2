using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Flower
    {
        public abstract string Name { get; }
        public abstract int Price { get; }
        public int Length;
        public string Fresh;

        public void GetInfo()
        {
            Console.WriteLine("===================");
            Console.WriteLine($"Type: {Name}");
            Console.WriteLine($"Price: {Price} UAH");
            Console.WriteLine($"Length:{Length} cm");
            Console.WriteLine($"Fresh: {Fresh}");
            Console.WriteLine("===================");
        }

    }
}
