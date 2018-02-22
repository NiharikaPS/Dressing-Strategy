using Dressing.Business.Rules;
using System.Collections.Generic;
using System.Linq;

namespace Dressing.Business.TemperatureStrategy
{
    public abstract class TemperatureStrategy
    {
        protected RuleParameter _ruleParameter;
        protected IList<IRule> _ruleEngine;

        private Queue<string> _inputCommandIds;
        public IList<string> _output;
        private IList<CommandType> _currentCommandList;
        public string _message;
        private IList<CommandType> _clothingCommands;

        public TemperatureStrategy()
        {
            _ruleEngine = new List<IRule>();
            InitializeRules();
            _clothingCommands = GetClothing();
        }
        /// <summary>
        /// This method should be implemented by inheriting classes to load the rule engine with applicable rules.
        /// </summary>
        protected abstract void InitializeRules();

        /// <summary>
        /// This method should be implemented by inheriting classes to get the 
        /// response based on the temperature type and command
        /// </summary>
        /// <param name="commandId"></param>
        /// <returns></returns>
        protected abstract string GetResponse(CommandType commandId);

        private void Initialize()
        {
            _message = string.Empty;
            _currentCommandList = new List<CommandType>();
            _output = new List<string>();
        }

        public void ProcessCommands(string inputCommandsStr)
        {
            Initialize();
            _inputCommandIds = new Queue<string>(inputCommandsStr.Split(','));
            while (_inputCommandIds.Count > 0)
            {
                string command = _inputCommandIds.Dequeue();
                int.TryParse(command.Trim(), out int commandIdInt);
                CommandType commandId = (CommandType)commandIdInt;

                _ruleParameter = new RuleParameter()
                {
                    ExistingCommandIds = _currentCommandList,
                    NewCommandId = commandId,
                    ClothingCommands = _clothingCommands,

                };

                if (AreRulesSatisfied())
                {
                    _currentCommandList.Add(commandId);
                    _output.Add(GetResponse(commandId));
                }
                else
                {
                    _output.Add("fail");
                    break;
                }
            }
        }

        private bool AreRulesSatisfied()
        {
            if (!_ruleEngine.Any())
            {
                _message = "Rules are not loaded into engine";
                return false;
            }
            foreach (IRule rule in _ruleEngine)
            {
                if (!rule.IsValid(_ruleParameter))
                {
                    _message = rule.Description;
                    return false;
                }
            }
            return true;
        }

        protected abstract IList<CommandType> GetClothing();
    }
}
