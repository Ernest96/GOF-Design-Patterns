using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.AbstractFactory
{
    abstract class Hero
    {
        protected int health { get; set; }
        protected int speed { get; set; }
        protected string weapon { get; set; }

        public abstract void Walk();

        public override string ToString()
        {
            return "Hero info:\n" +
                   $"  Health = {health}\n" +
                   $"  Speed = {speed}\n" +
                   $"  Weapon = {weapon}\n";
        }
    }
}
