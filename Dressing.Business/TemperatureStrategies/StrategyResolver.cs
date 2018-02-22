using System;

namespace Dressing.Business.TemperatureStrategy
{
   /// <summary>
   /// This class helps to instantiate the temperature strategy based on temperature type.
   ///  
   /// </summary>
    public static class StrategyResolver
    {
        /// <summary>
        /// At present, HOT & COLD are supported. In future, to support new strategy, modify this method.
        /// </summary>
        /// <param name="temperatureType">HOT Or COLD</param>
        /// <returns></returns>
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
