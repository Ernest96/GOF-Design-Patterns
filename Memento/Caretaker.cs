using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Memento
{
    class Caretaker
    {
        private Memento memento;

        public Memento GetMemento()
        {
            return memento;
        }

        public void SetMemento(Memento memento)
        {
            this.memento = memento;
        }

    }
}
