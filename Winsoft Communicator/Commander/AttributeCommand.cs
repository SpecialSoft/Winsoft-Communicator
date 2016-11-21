using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winsoft_Communicator.Commander
{
    public class AttributeCommand
    {
        private string command;
        private string[] attributesNames;

        public AttributeCommand(string command, string[] attributesNames)
        {
            this.command = command;
            this.attributesNames = attributesNames;
        }

        public void Call(string[] attributes)
        {
            if (attributes.Length == attributesNames.Length)
            {
                RawCall(attributes);
            }
            else if (attributes.Length < attributesNames.Length ||
                     attributes.Length > attributesNames.Length)
                throw new IndexOutOfRangeException("You must specify " + attributesNames.Length + " attributes");
        }

        public virtual void RawCall(string[] attributes)
        {
            string attributesToShow = "";
            foreach(string attribute in attributes)
            {
                if (attributesToShow == "")
                    attributesToShow = attribute;
                else
                    attributesToShow += ", " + attribute;
            }
            Console.WriteLine("Called command " + command + ". With attributes ");
        }
    }
}
