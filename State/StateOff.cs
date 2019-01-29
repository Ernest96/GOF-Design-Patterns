using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.State
{
    class StateOff : State
    {
        public override void Handle(Televizor tv)
        {
            tv.State = new StateOn();
        }
    }
}
