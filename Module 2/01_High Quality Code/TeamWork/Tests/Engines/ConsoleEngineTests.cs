﻿namespace Battlefield.Tests.Engines
{
    using Logic.Engines;
    using Logic.Fields;
    using Logic.InputProviders;
    using Logic.Players;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ConsoleEngineTests
    {
        private static IPlayer pesho = new Player("Pesho", new Field(10, 20), new ConsoleInput(10));
        private static IPlayer gosho = new Player("Gosho", new Field(10, 20), new ConsoleInput(10));
        private IEngine consoleEngine = new ConsoleEngine(pesho, gosho);

        [TestMethod]
        public void ConsoleEngineTestIfSettingWorks()
        {
            Assert.IsTrue(this.consoleEngine != null);
            Assert.AreEqual(false, this.consoleEngine.IsGameOver);
        }

        [Ignore]
        public void StartTestIfSettingWorks()
        {
            Assert.Fail();
        }
    }
}