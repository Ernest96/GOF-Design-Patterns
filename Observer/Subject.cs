using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Observer
{
    abstract class Subject
    {
        protected List<Observer> _list = new List<Observer>();
        public string state;

        public abstract void Notify();
        public abstract void AddObserver(Observer observer);
        public abstract void RemoveObserver(Observer observer);

    }
}
