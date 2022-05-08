using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Chamomile : Flower
    {
        public override string Name => "Chamomile";
        public override int Price => 12;

        public Chamomile(int length, string fresh)
        {
            Length = length;
            Fresh = fresh;

        }
    }
}
