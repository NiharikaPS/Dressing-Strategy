using Pajamas.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pajamas
{
    /// <summary>
    /// Extension methods common to all the temperature types.
    /// </summary>
    public static class CommandExtensions
    {
        public static Command GetCommand(CommandType commandId)
        {
            return SampleCommands.commands.Where(x => x.Id == (int)commandId).FirstOrDefault();
        }

    }
}
