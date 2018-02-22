using System;

namespace Dressing.Business.TemperatureStrategy
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
