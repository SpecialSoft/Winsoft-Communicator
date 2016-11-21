using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winsoft_Communicator.Commander;

namespace Winsoft_Communicator
{
    public class Commanders
    {
        private static List<AttributeCommand> attributeCommands = new List<AttributeCommand>();
        private static List<ClearCommand> clearCommands = new List<ClearCommand>();

        public static void AddCommand(AttributeCommand command)
        {
            attributeCommands.Add(command);
        }
        public static void AddCommand(ClearCommand command)
        {
            clearCommands.Add(command);
        }
    }
}
