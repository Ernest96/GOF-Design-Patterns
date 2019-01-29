using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Bridge
{
    //Concrete implementor
    class DvdDevice : EntertainmentDevice
    {
        public DvdDevice(int newState, int newMaxSetting)
        {
            state = newState;
            maxSetting = newMaxSetting;
        }

        public override void buttonDownPressed()
        {
            state--;
            if (state < 0)
                state = 0;
            Console.WriteLine("Previous video");
        }

        public override void buttonUpPressed()
        {
            state++;
            if (state > maxSetting)
                state = 0;
            Console.WriteLine("Next video");
        }
        
    }
}
