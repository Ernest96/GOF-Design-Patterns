using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Mediator
{
    abstract class AbstractUser
    {
        protected Mediator mediator;

        public AbstractUser(Mediator m)
        {
            mediator = m;
        }

        public abstract void Notify(string message);
    }
}
