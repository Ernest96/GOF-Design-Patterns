using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Decorator
{
    class Knife : HeroDecorator
    {
        public Knife()
        {
            Console.WriteLine("Adding knife !");
        }

        public override int getArmor()
        {
            return _hero.getArmor();
        }

        public override int getDamage()
        {
            return _hero.getDamage() + 50;
        }
    }
}
