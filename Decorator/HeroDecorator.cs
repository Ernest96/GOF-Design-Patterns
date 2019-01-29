using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Decorator
{
    abstract class HeroDecorator : Hero
    {
        protected Hero _hero;

        public HeroDecorator()
        {
            
        }

        public void SetComponent(Hero hero)
        {
            _hero = hero;
        }

        public override int getArmor()
        {
            return _hero.getArmor();
        }

        public override int getDamage()
        {
            return _hero.getDamage();
        }

    }
}
