using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pajamas.Enums;

namespace Pajamas.Rules
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
