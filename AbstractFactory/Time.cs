using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.AbstractFactory
{
    class Time
    {
        private string[] type = {"morning", "afternoon", "evening"};
        private int timeIndex = 0;

        public void Change()
        {
            if (timeIndex >= type.Length - 1)
            {
                timeIndex = 0;
            }

            Console.WriteLine($"Time is {type[timeIndex]}.");

            timeIndex++;
        }
    }
}
