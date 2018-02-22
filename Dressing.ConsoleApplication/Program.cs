using Dressing.Business;
using Dressing.Business.TemperatureStrategy;
using System;
using System.Collections.Generic;

namespace Dressing.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureType type = TemperatureType.HOT;
            string inputCommands = "8, 6, 6";
            //  "Removing PJs", "shorts", "fail" 

            TemperatureStrategy temperatureStrategy = StrategyResolver.GetTemperatureStrategy(type);
            temperatureStrategy.ProcessCommands(inputCommands);
            Console.WriteLine(string.Join(",",temperatureStrategy._output));
            Console.WriteLine(temperatureStrategy._message);
            Console.ReadKey();
        }
    }
}
