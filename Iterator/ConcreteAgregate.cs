using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Iterator
{
    class ConcreteAgregate : Agregate
    {
        ArrayList ar = new ArrayList();

        public override Iterator GetIterator()
        {
            return new ConcreteIterator(this);
        }

        public object this[int index]
        {
            get { return ar[index]; }
            set { ar.Insert(index, value);  }
        }

        public int Count
        {
            get { return ar.Count; }
        }


    }
}
