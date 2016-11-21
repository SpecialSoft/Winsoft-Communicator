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
        public static List<AttributeCommand> attributeCommands = new List<AttributeCommand>();
        public static List<ClearCommand> clearCommands = new List<ClearCommand>();

        public static void AddCommand(AttributeCommand command)
        {
            attributeCommands.Add(command);
        }
        public static void AddCommand(AttributeCommand[] commands)
        {
            foreach (AttributeCommand command in commands)
            {
                attributeCommands.Add(command);
            }
        }
        public static void AddCommand(ClearCommand command)
        {
            clearCommands.Add(command);
        }
        public static void AddCommand(ClearCommand[] commands)
        {
            foreach (ClearCommand command in commands)
            {
                clearCommands.Add(command);
            }
        }
    }
}
