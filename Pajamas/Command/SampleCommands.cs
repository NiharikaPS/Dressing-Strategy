using System.Collections.Generic;

namespace Dressing.Business.Command
{
    public static class SampleCommands
    {
        // NULL in response indicates FAIL
        public static readonly IList<Command> commands = new List<Command>()
        {
            new Command { Id = 1 , Description = "Put on footwear", HotResponse = "sandals" , ColdResponse = "boots"     },
            new Command { Id = 2 , Description = "Put on headwear", HotResponse = "sun visor" , ColdResponse = "hat"  },
            new Command { Id = 3 , Description = "Put on socks", HotResponse = null , ColdResponse = "socks"},
            new Command { Id = 4 , Description = "Put on shirt", HotResponse = "t-shirt" , ColdResponse = "shirt"},
            new Command { Id = 5 , Description = "Put on jacket", HotResponse = null , ColdResponse = "jacket" },
            new Command { Id = 6 , Description = "Put on pants", HotResponse = "shorts" , ColdResponse = "pants"  },
            new Command { Id = 7 , Description = "Leave house", HotResponse = "leaving house" , ColdResponse = "leaving house"},
            new Command { Id = 8 , Description = "Take off pajamas", HotResponse = "Removing PJs" , ColdResponse = "Removing PJs"},
        };
    }
}
