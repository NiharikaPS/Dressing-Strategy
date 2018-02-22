using Pajamas.Enums;
using Pajamas.Rules;
using System.Collections.Generic;

namespace Pajamas
{
    public class NoSocksWhenHot : IRule
    {
        public string Description => "You cannot put on socks when it is hot";

        public bool IsValid(RuleParameter ruleParameter)
        {
            if (ruleParameter.NewCommandId == CommandType.PUT_SOCKS)
                return false;

            return true;
        }
    }
}
