using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Strategy
{
    class Context
    {
        Strategy strategy;
        List<string> list = new List<string>();

        public void SetStrategy(Strategy s)
        {
            strategy = s;
        }

        public void Sort()
        {
            if (strategy != null)
            {
                strategy.Sort(list);
            }
            else
            {
                Console.WriteLine("No strategy sort");
            }
        }
    }
}
