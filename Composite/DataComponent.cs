using IPP.FlyWeight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Composite
{
    abstract class DataComponent
    {
        public string name { get; set; }
        public string data { get; set; }
        public int size { get; set; }
        public string extension { get; set; }
        public FlyWeightIcon icon { get; set; }

        public DataComponent()
        {

        }

        public abstract DataComponent Add(DataComponent c);
        public abstract DataComponent Remove(DataComponent c);
        public abstract void Display(int depth = 0);
        public abstract void ShowData();
    }
}
