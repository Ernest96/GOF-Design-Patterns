using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.State
{
    class Televizor
    {
        private State state;

        public Televizor(State state)
        {
            this.state = state;
        }

        public void PressButton()
        {
            state.Handle(this);
        }

        public State State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
