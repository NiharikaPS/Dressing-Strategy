using Pajamas.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Pajamas.Rules
{
    /// <summary>
    /// Pajamas must be taken off before anything else can be put on
    /// </summary>
    public class NoPajamasBeforeAnyOtherClothing : IRule
    {
        public string Description => "Pajamas must be taken off before anything else can be put on";

        public bool IsValid(RuleParameter ruleParameter)
        {
            if (!ruleParameter.ExistingCommandIds.Any() && ruleParameter.NewCommandId != CommandType.TAKE_OFF_PAJAMAS)
                return false;
            return true;
        }
    }
}
