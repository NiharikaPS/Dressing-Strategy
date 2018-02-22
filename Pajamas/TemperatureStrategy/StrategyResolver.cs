using Pajamas.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pajamas.TemperatureStrategy
{
    public static class StrategyResolver
    {
        public static TemperatureStrategy GetTemperatureStrategy(TemperatureType temperatureType)
        {
            switch (temperatureType)
            {
                case TemperatureType.HOT:
                    return new HotTemperatureStrategy();
                case TemperatureType.COLD:
                    return new ColdTemperatureStrategy();
                default:
                    throw new TypeAccessException();

            }

        }
    }
}
