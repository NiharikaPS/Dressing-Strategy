﻿using Pajamas.Enums;
using System.Collections.Generic;

namespace Pajamas.Rules
{
    public class RuleParameter
    {
        public IList<CommandType> ExistingCommandIds { get; set; }
        public CommandType NewCommandId { get; set; }
        public IList<CommandType> ClothingCommands { get; set; }
    }
}
