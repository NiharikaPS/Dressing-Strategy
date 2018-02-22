using Pajamas.Enums;
using System.Collections.Generic;

namespace Pajamas.Rules
{
    public class PutPantsBeforeShoes : IRule
    {
        public string Description => "Pants must be put on before shoes";
        

        public bool IsValid(RuleParameter ruleParameter)
        {
            if (ruleParameter.NewCommandId == CommandType.PUT_FOOT_WEAR && !ruleParameter.ExistingCommandIds.Contains(CommandType.PUT_PANTS))
                return false;
            return true;
        }
    }
}
