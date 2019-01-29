using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Bridge
{
    //Refined Abstraction
    class UniversalRemote : Remote
    {
        public override void buttonInfoPressed()
        {
            Console.WriteLine("You are using your remote with device: " + this.GetDeviceType());
        }
    }
}
