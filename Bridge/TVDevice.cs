using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Bridge
{
    //CONCRETE IMPLEMENTOR
    class TVDevice : EntertainmentDevice
    {
        public TVDevice(int newState, int newMaxSetting)
        {
            state = newState;
            maxSetting = newMaxSetting;
        }

        public override void buttonDownPressed()
        {
            state--;
            Console.WriteLine("Channel Down");
        }

        public override void buttonUpPressed()
        {
            state++;
            Console.WriteLine("Channel UP");
        }
    }
}
