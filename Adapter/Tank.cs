using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Adapter
{
    public class Tank : IEnemyDestroyer
    {
        public void fireWeapon()
        {
            int attackDamage = 25;
            Console.WriteLine("Enemy Tank Does " + attackDamage + " Damage");
        }

        public void driveForward()
        {
            int movement = 2;
            Console.WriteLine("Tank moves " + movement + " meter");
        }
    }
}
