using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Bridge
{
    //ABSTRACTION
    abstract class Remote
    {
        private EntertainmentDevice theDevice;

        public Remote(EntertainmentDevice newDevice)
        {
            theDevice = newDevice;
        }

        public Remote()
        {
        }

        public void setDevice(EntertainmentDevice device)
        {
            this.theDevice = device;
        }

        public void buttonLeftPressed()
        {
            theDevice.buttonLeftPressed();
        }

        public void buttonRightPressed()
        {
            theDevice.buttonRightPressed();
        }

        public void buttonUpPressed()
        {
            theDevice.buttonUpPressed();
        }

        public void buttonDownPressed()
        {
            theDevice.buttonDownPressed();
        }

        protected string GetDeviceType()
        {
            return theDevice.GetType().ToString();
        }

        public abstract void buttonInfoPressed();
    }
}
