using System.Collections.Generic;

namespace Dressing.Business.Rules
{
    public class PutShirtBeforeHeadWearOrJacket : IRule
    {
        private readonly IList<CommandType> _commands = new List<CommandType> { CommandType.PUT_HEAD_WEAR, CommandType.PUT_JACKET };
        public string Description => "The shirt must be put on before the headwear or jacket";

        public bool IsValid(RuleParameter ruleParameter)
        {
            if (_commands.Contains(ruleParameter.NewCommandId) 
                && !ruleParameter.ExistingCommandIds.Contains(CommandType.PUT_SHIRT))
                return false;
            return true;
        }
    }
}
