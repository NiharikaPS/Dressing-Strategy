using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pajamas.Enums;

namespace Pajamas.Rules
{
    public class NoJacketWhenHot : IRule
    {
        public string Description => "You cannot put on a jacket when it is hot";

        public bool IsValid(RuleParameter ruleParameter)
        {
            if (ruleParameter.NewCommandId == CommandType.PUT_JACKET)
                return false;

            return true;
        }
    }
}
