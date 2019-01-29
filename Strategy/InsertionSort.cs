using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Strategy
{
    class InsertionSort : Strategy
    {
        public override void Sort(List<string> list)
        {
            //sort by insertion sort
            list.Sort();
        }
    }
}
