using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.AbstractFactory
{
    abstract class Map
    {
        protected string mapName;
        protected string mapTexture;

        public abstract void Spawn(Hero hero);
    }
}
