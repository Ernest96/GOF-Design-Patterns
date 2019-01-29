using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Observer
{
    class ConcreteSubject : Subject
    {
        public override void AddObserver(Observer observer)
        {
            _list.Add(observer);
        }

        public override void Notify()
        {
            foreach (var x in _list)
            {
                x.Update(state);
            }
        }

        public override void RemoveObserver(Observer observer)
        {
            _list.Remove(observer);
        }
    }
}
