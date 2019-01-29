using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Mediator
{
    abstract class Mediator
    {
        public abstract void Send(string message, AbstractUser user);
    }
}
