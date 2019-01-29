using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.AbstractFactory
{
    class Level
    {
        public Hero hero { get; private set; }
        public Map map { get; private set;  }
        public Time time { get; private set; }

        public Level(AbstractLevelFactory factory)
        {
            hero = factory.CreateHero();
            map = factory.CreateMap();
            time = new Time();
        }

        public void SpawnHero()
        {
            map.Spawn(hero);
        }

    }
}
