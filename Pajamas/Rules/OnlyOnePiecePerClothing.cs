namespace Dressing.Business.Rules
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
