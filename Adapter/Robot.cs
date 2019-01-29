using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Adapter
{
    //Adaptee
    public class Robot
    {
        public void smashWithHands()
        {
            int attackDamage = 7;
            Console.WriteLine("Enemy Robot Causes " + attackDamage + " Damage With Its Hands");
        }

        public void flyForward()
        {
            int movement = 1;
            Console.WriteLine("Enemy Robot Walks Forward " + movement + " meter");
        }

    }
}
