using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tulip : Flower
    {
        public override string Name { get { return "Tulip"; } }

        public override int Price { get { return 23; } }

        public Tulip(int length, string fresh)
        {
            Length = length;
            Fresh = fresh;
        }
    }
}
