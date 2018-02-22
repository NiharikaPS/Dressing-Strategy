using Dressing.Business.Command;
using Dressing.Business.Rules;
using System.Collections.Generic;
using System.Linq;

namespace Dressing.Business.TemperatureStrategy
{
    public class HotTemperatureStrategy : TemperatureStrategy
    {
        protected override IList<CommandType> GetClothing()
        {
            return SampleCommands.commands.Where(x => x.Description.StartsWith(Constants.PUT_ON)
                                                                && x.HotResponse != null
                                                                )
                        .Select(x => (CommandType)x.Id).ToList();
        }
        protected override string GetResponse(CommandType commandId)
        {
            return CommandExtensions.GetCommand(commandId).HotResponse;

        }
        protected override void InitializeRules()
        {
            _ruleEngine.Add(new IsCommandValid());
            _ruleEngine.Add(new OnlyOnePiecePerClothing());
            _ruleEngine.Add(new NoPajamasBeforeAnyOtherClothing());
            _ruleEngine.Add(new NoJacketWhenHot());
            _ruleEngine.Add(new NoSocksWhenHot());
            _ruleEngine.Add(new PutShirtBeforeHeadWearOrJacket());
            _ruleEngine.Add(new AllClothingOnBeforeLeaving());
        }
    }
}
