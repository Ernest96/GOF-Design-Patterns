using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.AbstractFactory
{
    class Ninja : Hero
    {
        public Ninja()
        {
            health = 100;
            speed = 125;
            weapon = "Knife";
        }

        public override void Walk()
        {
            Console.WriteLine("Ninja walks. ");
        }
    }
}
