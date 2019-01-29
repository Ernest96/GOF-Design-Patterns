using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Iterator
{
    class ConcreteIterator : Iterator
    {
        ConcreteAgregate ag;
        int index = 0;

        public ConcreteIterator(ConcreteAgregate a)
        {
            ag = a;
        }

        public override object Current()
        {
            return ag[index];
        }

        public override object First()
        {
            return ag[0];
        }

        public override bool IsDone()
        {
            return index > ag.Count;
        }

        public override object Next()
        {
            if (!IsDone())
            {
                ++index;
                return ag[index];
            }

            return null;
        }
    }
}
