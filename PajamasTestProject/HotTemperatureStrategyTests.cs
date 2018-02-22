using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pajamas.Enums;
using Pajamas.TemperatureStrategy;
using System.Collections.Generic;

namespace PajamasTestProject
{
    [TestClass]
    public class HotTemperatureStrategyTests
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
        public HotTemperatureStrategyTests()
        {
            type = TemperatureType.HOT;
            temperatureStrategy = StrategyResolver.GetTemperatureStrategy(type);

        }

        [TestMethod]
        public void ShouldHaveProcessedWhenAllClothingAndLeaveOnHotDay()
        {
            string inputCommands = "8, 6, 4, 2, 1, 7";
            List<string> expectedOutput = new List<string> { "Removing PJs", "shorts", "t-shirt", "sun visor", "sandals", "leaving house" };
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine("Success");
        }

        [TestMethod]
        public void ShouldHaveFailWhenJacketOnHotDay()
        {
            string inputCommands = "8, 6, 4, 2, 1, 5, 7";
            List<string> expectedOutput = new List<string> { "Removing PJs", "shorts", "t-shirt", "sun visor", "sandals", "fail" };
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine(temperatureStrategy._message);
        }

        [TestMethod]
        public void ShouldHaveFailWhenNotAllClothingAndLeaveOnHotDay()
        {
            string inputCommands = "8, 6, 4, 1, 7";
            List<string> expectedOutput = new List<string> { "Removing PJs", "shorts", "t-shirt", "sandals", "fail" };
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine("Success");
        }


        [TestMethod]
        public void ShouldHaveProcessedWhenSandalsBeforePantsOnHotDay()
        {
            string inputCommands = "8, 6, 6";
            List<string> expectedOutput = new List<string> { "Removing PJs", "shorts", "fail" };
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine(temperatureStrategy._message);
        }


        [TestMethod]
        public void ShouldHaveFailWhenSocksOnHotDay()
        {
            string inputCommands = "8, 6, 3";
            List<string> expectedOutput = new List<string> { "Removing PJs", "shorts", "fail" };
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine(temperatureStrategy._message);
        }
        [TestMethod]
        public void ShouldHaveFailWhenHeadWearBeforeShirtOnHotDay()
        {
            string inputCommands = "8, 6, 2, 4, 1, 7";
            List<string> expectedOutput = new List<string> { "Removing PJs", "shorts", "fail" };
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine(temperatureStrategy._message);

        }

        [TestMethod]
        public void ShouldHaveFailWhenJacketBeforeShirtOnHotDay()
        {
            string inputCommands = "8, 6, 5, 4, 1, 7";
            List<string> expectedOutput = new List<string> { "Removing PJs", "shorts", "fail" };
            temperatureStrategy.ProcessCommands(inputCommands);
            CollectionAssert.AreEqual(expectedOutput, temperatureStrategy._output as List<string>);
            TestContext.WriteLine(temperatureStrategy._message);

        }


    }
}
