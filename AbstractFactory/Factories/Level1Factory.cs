using IPP.AbstractFactory.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.AbstractFactory
{
    class Level1Factory : AbstractLevelFactory 
    {
        public override Hero CreateHero()
        {
            return new Knight();
        }

        public override Map CreateMap()
        {
            return new MountainsMap();
        }
    }
}
