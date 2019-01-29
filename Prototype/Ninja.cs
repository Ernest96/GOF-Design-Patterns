using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Prototype
{
    class Ninja : IEnemy
    {
        public int damage { get; set; }
        public int life { get; set; }
        public string color { get; set; }
        public string weapon { get; set; }
        //public int id { get; set; }

        public Ninja(string _color, string _weapon)
        {
            //id = _id;
            color = _color;
            weapon = _weapon;
            damage = 25;
            life = 100;
        }

        public IEnemy Clone()
        {
            var result = (IEnemy)this.MemberwiseClone();
            return result;
        }

        public int Attack()
        {
            Console.WriteLine($"Ninja  atack!");
            Console.WriteLine($"   Color: {color}");
            Console.WriteLine($"   Weapon: {weapon}");
            Console.WriteLine($"   Damage: {damage}");
            Console.WriteLine($"_________________________\n");
            return damage;
        }
    }
}
