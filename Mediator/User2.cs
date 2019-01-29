using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Mediator
{
    class User2 : AbstractUser
    {
        public User2(Mediator m) : base(m)
        {

        }

        public override void Notify(string message)
        {
            Console.WriteLine("User2 receive : " + message);

        }
    }
}
