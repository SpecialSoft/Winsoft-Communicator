using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winsoft_Communicator
{
    public class ClearCommand
    {
        private string command;

        public ClearCommand(string command)
        {
            this.command = command;
        }

        public virtual void OnCall()
        {
            Console.WriteLine("Called command " + command);
        }
    }
}
