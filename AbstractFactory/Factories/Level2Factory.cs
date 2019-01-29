using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPP.AbstractFactory.Maps;

namespace IPP.AbstractFactory
{
    class Level2Factory : AbstractLevelFactory
    {
        public override Hero CreateHero()
        {
            return new Ninja();
        }

        public override Map CreateMap()
        {
            return new WoodMap();
        }
    }
}
