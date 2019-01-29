using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Strategy
{
    abstract class Strategy
    {
        public abstract void Sort(List<string> list);
    }
}
