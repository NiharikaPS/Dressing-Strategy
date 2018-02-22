namespace Dressing.Business.Rules
{
    public class NoJacket : IRule
    {
        public string Description => "You cannot put on a jacket";

        public bool IsValid(RuleParameter ruleParameter)
        {
            if (ruleParameter.NewCommandId == CommandType.PUT_JACKET)
                return false;

            return true;
        }
    }
}
