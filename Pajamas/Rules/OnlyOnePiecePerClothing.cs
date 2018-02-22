using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pajamas.Enums;

namespace Pajamas.Rules
{
    public class OnlyOnePiecePerClothing : IRule
    {
        public string Description => "Only 1 piece of each type of clothing may be put on";

        public bool IsValid(RuleParameter ruleParameter)
        {
            if (ruleParameter.ExistingCommandIds.Contains(ruleParameter.NewCommandId))
                return false;
            return true;
        }
    }
}
