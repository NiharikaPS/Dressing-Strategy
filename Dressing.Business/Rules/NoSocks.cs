namespace Dressing.Business.Rules
{
    public class NoSocks : IRule
    {
        public string Description => "You cannot put on socks";

        public bool IsValid(RuleParameter ruleParameter)
        {
            if (ruleParameter.NewCommandId == CommandType.PUT_SOCKS)
                return false;

            return true;
        }
    }
}
