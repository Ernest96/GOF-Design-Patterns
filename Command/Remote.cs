using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Command
{
    class Remote
    {
        private Commanda command;

        public void SetCommand(Commanda command)
        {
            this.command = command;
        }

        public void Invoke()
        {
            command.Execute();
        }
    }
}
