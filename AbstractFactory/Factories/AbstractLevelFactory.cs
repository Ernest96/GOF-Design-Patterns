using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.AbstractFactory
{
    abstract class AbstractLevelFactory
    {
        public abstract Hero CreateHero();
        public abstract Map CreateMap();
    }
}

