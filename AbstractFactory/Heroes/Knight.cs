using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.AbstractFactory
{
    class Knight : Hero
    {
        public Knight()
        {
            health = 125;
            speed = 75;
            weapon = "Sword";
        }

        public override void Walk()
        {
            Console.WriteLine("Knight walks. ");
        }
    }
}
