using IPP.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.AbstractFactory.Maps
{
    class WoodMap : Map
    {
        public WoodMap()
        {
            this.mapName = "woods";
            this.mapTexture = "/resources/wood.texture";
        }

        public override void Spawn(Hero hero)
        {
            Console.WriteLine(hero.GetType().Name + " appears in the " + this.GetType().Name);
            Console.WriteLine(hero.ToString());
            Console.WriteLine("___________________\n");
        }
    }
}
