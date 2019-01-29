using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Bridge
{
    //ABSTRACT IMPLEMENTOR
    abstract class EntertainmentDevice
    {
        public int maxSetting;
        public int state;
        public int volume = 0;
        public abstract void buttonDownPressed();
        public abstract void buttonUpPressed();

        public void buttonLeftPressed()
        {
            volume++;
            Console.WriteLine("volume: " + volume);
        }

        public void buttonRightPressed()
        {
            volume--;
            Console.WriteLine("volume: " + volume);
        }
    }
}
