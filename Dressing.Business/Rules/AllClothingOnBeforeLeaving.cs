﻿using System.Linq;

namespace Dressing.Business.Rules
{
    public class AllClothingOnBeforeLeaving : IRule
    {
        public string Description => @"You cannot leave the house until
                    all items of clothing are on (except socks and a jacket when
                    it’s hot)";



        public bool IsValid(RuleParameter ruleParameter)
        {
            if (ruleParameter.NewCommandId == CommandType.LEAVE_HOUSE
                && !(ruleParameter.ExistingCommandIds.Intersect(ruleParameter.ClothingCommands).Count() == ruleParameter.ClothingCommands.Count))
                return false;
            return true;
        }
    }
}
