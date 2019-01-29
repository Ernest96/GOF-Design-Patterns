using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Command
{
    abstract class Commanda
    {
        protected TV receiver;

        public Commanda(TV tv)
        {
            receiver = tv;
        }

        public abstract void Execute();
    }
}
