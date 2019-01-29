using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Command
{
    class VolumeUp : Commanda
    {
        public VolumeUp(TV tv) : base(tv)
        {

        }

        public override void Execute()
        {
            receiver.VolumeUp();
        }
    }
}
