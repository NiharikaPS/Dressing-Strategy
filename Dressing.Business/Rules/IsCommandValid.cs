using Dressing.Business.Command;
using System.Linq;

namespace Dressing.Business.Rules
{
    class IsCommandValid : IRule
    {
        public string Description => "Check if command is valid";
        

        public bool IsValid(RuleParameter ruleParameter)
        {
            return SampleCommands.commands.Select(x => x.Id).Contains((int)ruleParameter.NewCommandId);
        }
    }
}
