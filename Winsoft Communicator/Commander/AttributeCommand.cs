using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winsoft_Communicator.Commander
{
    public abstract class AttributeCommand
    {
        public string command;
        public string[] attributesNames;

        public AttributeCommand(string command, string[] attributesNames)
        {
            this.command = command;
            this.attributesNames = attributesNames;
        }

        public void Call(string[] commandWithAttributes)
        {
            string[] allCommandWithAttr = { };
            int counter = 0;
            foreach(string commandInAll in commandWithAttributes)
            {
                if(counter == 0)
                {
                    continue;
                }
                allCommandWithAttr[allCommandWithAttr.Length] = commandInAll;
                counter++;
            }
            if (command.Equals(this.command, StringComparison.CurrentCultureIgnoreCase))
                AfterCall(allCommandWithAttr);
        }

        public void AfterCall(string[] attributes)
        {
            if (attributes.Length == attributesNames.Length)
            {
                OnCall(attributes);
            }
            else if (attributes.Length < attributesNames.Length ||
                     attributes.Length > attributesNames.Length)
                throw new IndexOutOfRangeException("You must specify " + attributesNames.Length + " attributes in command " + command);
        }

        public abstract void OnCall(string[] attributes);
        
        private void MustOnCaught(string[] attributes)
        {
            string attributesToShow = "";
            foreach (string attribute in attributes)
            {
                if (attributesToShow == "")
                    attributesToShow = attribute;
                else
                    attributesToShow += ", " + attribute;
            }
            Console.WriteLine("Called command " + command + ". With attributes " + attributes);
        }
    }
}
