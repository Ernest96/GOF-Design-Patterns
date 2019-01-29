using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.AbstractFactory
{
    class MountainsMap : Map
    {
        public MountainsMap()
        {
            this.mapName = "mountains";
            this.mapTexture = "/resources/mount.texture";
        }

        public override void Spawn(Hero hero)
        {
            Console.WriteLine(hero.GetType().Name + " appears in the " +  this.GetType().Name);
            Console.WriteLine(hero.ToString());
            Console.WriteLine("___________________\n");
        }
    }
}
