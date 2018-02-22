namespace Dressing.Business.Rules
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
