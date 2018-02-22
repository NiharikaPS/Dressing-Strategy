using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pajamas.Enums;

namespace Pajamas.Rules
{
    public class PutSocksBeforeShoes : IRule
    {
        public string Description => "Socks must be put on before shoes";

        public bool IsValid(RuleParameter ruleParameter)
        {

            if (
               ruleParameter.NewCommandId == CommandType.PUT_FOOT_WEAR
                              && !ruleParameter.ExistingCommandIds.Contains(CommandType.PUT_SOCKS)
                )
                return false;
            return true;
        }
    }

}
