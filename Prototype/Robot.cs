using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Prototype
{
    class Robot : IEnemy
    {
        public int damage { get; set; }
        public int life { get; set; }
        public string color { get; set; }
        public string weapon { get; set; }
        //public int id { get; set; }

        public Robot(string _color, string _weapon)
        {
            color = _color;
            weapon = _weapon;
            damage = 15;
            life = 145;
        }

        public IEnemy Clone()
        {
            return (IEnemy)this.MemberwiseClone();
        }

        public int Attack()
        {
            Console.WriteLine($"Robot  atack!");
            Console.WriteLine($"   Color: {color}");
            Console.WriteLine($"   Weapon: {weapon}");
            Console.WriteLine($"   Damage: {damage}");
            Console.WriteLine($"_________________________\n");
            return damage;
        }
    }
}
