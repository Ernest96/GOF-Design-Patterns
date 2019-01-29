using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Observer
{
    class ConcreteObserver : Observer
    {
        public string state { get; private set; }

        public override void Update(string newState)
        {
            state = newState;
        }
    }
}
