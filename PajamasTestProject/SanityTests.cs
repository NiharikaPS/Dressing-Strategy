using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pajamas.Enums;
using Pajamas.TemperatureStrategy;
using System.Collections.Generic;

namespace PajamasTestProject
{
    [TestClass]
    public class SanityTests
    {
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        [TestMethod]
        public void ShouldHaveFailWhenSameClothingAddedTwice()
        {
            TemperatureType type = TemperatureType.HOT;
            string inputCommands = "8, 6, 6";
            List<string> expectedOutput = new List<string> { "Removing PJs", "shorts", "fail" };
            TemperatureStrategy temperatureStrategy = StrategyResolver.GetTemperatureStrategy(type);
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine(temperatureStrategy._message);
        }


        [TestMethod]
        public void ShouldHaveFailWhenFirstCommandIsNotToRemovePajamas()
        {
            TemperatureType type = TemperatureType.COLD;
            string inputCommands = "6";
            List<string> expectedOutput = new List<string> { "fail" };
            TemperatureStrategy temperatureStrategy = StrategyResolver.GetTemperatureStrategy(type);
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine(temperatureStrategy._message);
        }

        [TestMethod]
        public void ShouldHaveFailWhenAnyCommandIsInvalid()
        {
            TemperatureType type = TemperatureType.COLD;
            string inputCommands = "8, 6, 10, 4, 2, 5, 1, 7";
            List<string> expectedOutput = new List<string> { "Removing PJs", "pants", "fail" };
            TemperatureStrategy temperatureStrategy = StrategyResolver.GetTemperatureStrategy(type);
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine(temperatureStrategy._message);

        }

        [TestMethod]
        public void ShouldHaveFailWhenAnyCommandIsNotANumber()
        {
            TemperatureType type = TemperatureType.COLD;
            string inputCommands = "8, 6, zz, 4, 2, 5, 1, 7";
            List<string> expectedOutput = new List<string> { "Removing PJs", "pants", "fail" };
            TemperatureStrategy temperatureStrategy = StrategyResolver.GetTemperatureStrategy(type);
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine(temperatureStrategy._message);

        }

        [TestMethod]
        public void ShouldHaveFailWhenFirstElementIsNotANumber()
        {
            TemperatureType type = TemperatureType.HOT;
            string inputCommands = "zz, 6, 4, 2, 1, 7";
            List<string> expectedOutput = new List<string> { "fail" };
            TemperatureStrategy temperatureStrategy = StrategyResolver.GetTemperatureStrategy(type);
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine(temperatureStrategy._message);

        }



    }
}
