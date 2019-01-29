using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Mediator
{
    class User1 : AbstractUser
    {
        public User1(Mediator m): base(m)
        {
        }
        public override void Notify(string message)
        {
            Console.WriteLine("User1 receive : " + message);
        }
    }
}
