using System.Linq;

namespace Dressing.Business.Command
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
