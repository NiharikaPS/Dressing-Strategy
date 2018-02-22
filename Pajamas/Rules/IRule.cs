namespace Dressing.Business.Rules
{
    /// <summary>
    /// Interface for Rule Definition
    /// </summary>
    public interface IRule
    {
        string Description { get; }
        bool IsValid(RuleParameter ruleParameter);
    }
}
