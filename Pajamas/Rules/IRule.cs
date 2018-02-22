using Pajamas.Enums;
using System.Collections.Generic;

namespace Pajamas.Rules
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
