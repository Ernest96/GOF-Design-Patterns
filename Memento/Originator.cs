using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Memento
{
    class Originator
    {
        public string state;

        public Memento GetMemento(string state)
        {
            return new Memento(state);
        }

        public void SetMemento(Memento memento)
        {
            state = memento.GetState();
        }
    }
}
