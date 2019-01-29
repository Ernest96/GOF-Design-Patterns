using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Decorator
{
    class Ninja : Hero
    {
        public override int getArmor()
        {
            return 1;
        }

        public override int getDamage()
        {
            return 5;
        }
    }
}
