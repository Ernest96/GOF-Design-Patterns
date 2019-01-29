using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Decorator
{
    class Armor : HeroDecorator
    {
        public Armor()
        {
            Console.WriteLine("Adding armor !");
        }

        public override int getArmor()
        {
            return _hero.getArmor() + 20;
        }

        public override int getDamage()
        {
            return _hero.getDamage();
        }
    }
}
