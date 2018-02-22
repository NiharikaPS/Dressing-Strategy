using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pajamas.Enums;
using Pajamas.Rules;

namespace Pajamas.TemperatureStrategy
{
    public class ColdTemperatureStrategy : TemperatureStrategy
    {
        protected override IList<CommandType> GetClothing()
        {
            return SampleCommands.commands.Where(x => x.Description.StartsWith(Constants.PUT_ON)
                                                                && x.ColdResponse != null
                                                                )
                        .Select(x => (CommandType)x.Id).ToList();
        }

        protected override string GetResponse(CommandType commandId)
        {
            return CommandExtensions.GetCommand(commandId).ColdResponse;

        }

        protected override void InitializeRules()
        {
            _ruleEngine.Add(new IsCommandValid());
            _ruleEngine.Add(new OnlyOnePiecePerClothing());
            _ruleEngine.Add(new NoPajamasBeforeAnyOtherClothing());
            _ruleEngine.Add(new PutSocksBeforeShoes());
            _ruleEngine.Add(new PutPantsBeforeShoes());
            _ruleEngine.Add(new PutShirtBeforeHeadWearOrJacket());
            _ruleEngine.Add(new AllClothingOnBeforeLeaving());
        }
    }
}
