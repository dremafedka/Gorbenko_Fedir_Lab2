using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rose : Flower
    {
        public override string Name { get { return "Rose"; } }

        public override int Price { get { return 30; } }

        public Rose(int length, string fresh)
        {
            Length = length;
            Fresh = fresh;
        }
    }
}
