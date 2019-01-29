using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.State
{
    abstract class State
    {
        public abstract void Handle(Televizor tv);
    }
}
