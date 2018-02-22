using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pajamas.Enums;
using Pajamas.TemperatureStrategy;
using System.Collections.Generic;

namespace PajamasTestProject
{
    [TestClass]
    public class ColdTemperatureStrategyTests
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

        private TemperatureType type;
        TemperatureStrategy temperatureStrategy;
        public ColdTemperatureStrategyTests()
        {

            type = TemperatureType.COLD;
            temperatureStrategy = StrategyResolver.GetTemperatureStrategy(type);

        }
        [TestMethod]
        public void ShouldHaveProcessedWhenAllClothingAndLeaveOnColdDay()
        {
            string inputCommands = "8, 6, 3, 4, 2, 5, 1, 7";
            List<string> expectedOutput = new List<string> { "Removing PJs", "pants", "socks", "shirt", "hat", "jacket", "boots", "leaving house" };
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine("Success");
        }
        [TestMethod]
        public void ShouldHaveFailWhenLeaveWithoutAllClothingOnColdDay()
        {
            string inputCommands = "8, 6, 3, 4, 2, 5, 7";
            List<string> expectedOutput = new List<string> { "Removing PJs", "pants", "socks", "shirt", "hat", "jacket", "fail" };
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine(temperatureStrategy._message);
        }


        [TestMethod]
        public void ShouldHaveFailWhenShoesBeforeSocksOnColdDay()
        {
            string inputCommands = "8, 1, 3, 4, 2, 5, 6, 7";
            List<string> expectedOutput = new List<string> { "Removing PJs", "fail" };     
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine(temperatureStrategy._message);

        }
        [TestMethod]
        public void ShouldHaveFailWhenHeadWearBeforeShirtOnColdDay()
        {
            string inputCommands = "8, 6, 3, 2, 4, 5, 1, 7";
            List<string> expectedOutput = new List<string> { "Removing PJs", "pants", "socks", "fail" };
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine(temperatureStrategy._message);

        }

        [TestMethod]
        public void ShouldHaveFailWhenJacketBeforeShirtOnColdDay()
        {
            string inputCommands = "8, 6, 3, 2, 5, 5, 1, 7";
            List<string> expectedOutput = new List<string> { "Removing PJs", "pants", "socks", "fail" };
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine(temperatureStrategy._message);

        }

        [TestMethod]
        public void ShouldHaveFailWhenShoesBeforePantsOnColdDay()
        {
            string inputCommands = "8, 6, 1, 4, 2, 5, 3, 7";
            List<string> expectedOutput = new List<string> { "Removing PJs", "pants", "fail" };
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine(temperatureStrategy._message);

        }
    }
}
