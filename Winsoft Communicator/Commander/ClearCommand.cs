using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winsoft_Communicator
{
    public abstract class ClearCommand
    {
        public string command;

        public ClearCommand(string command)
        {
            this.command = command;
        }

        public void Call(string command)
        {
            if (command.Equals(this.command, StringComparison.CurrentCultureIgnoreCase))
                OnCall();
        }

        public abstract void OnCall();
    }
}
