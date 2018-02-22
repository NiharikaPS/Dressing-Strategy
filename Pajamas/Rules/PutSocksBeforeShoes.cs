namespace Dressing.Business.Rules
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
