using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CoffeeMachine.Test
{
    /// <summary>
    /// Summary description for MainModuleTest
    /// </summary>
    [TestClass]
    public class MainModuleTests
    {
        public MainModuleTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
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


        [TestMethod]
        public void FillWaterTest()
        {
            
            // Создаем mock-объект
            var waterModule = new Mock<IWaterModule>();
            var coffeeModule = new Mock<ICoffeeModule>();
            var garbageModule = new Mock<IGarbageModule>();
            // Создаем тестируемый объект и передаем ему зависимость - mock-объект
            var mainModule = new MainModule(waterModule.Object, garbageModule.Object, coffeeModule.Object);
            // Вызываем метод, который мы тестируем
            mainModule.FillWater();
            waterModule.Verify(wm => wm.FillWater());
        }

        [TestMethod]
        public void MainModuleTest()
        {
            var waterModule = new Mock<IWaterModule>();
            var coffeeModule = new Mock<ICoffeeModule>();
            var garbageModule = new Mock<IGarbageModule>();
            var mainModule = new MainModule(waterModule.Object, garbageModule.Object, coffeeModule.Object);
            mainModule.MakeCoffee();
            waterModule.Verify(wm => wm.TakeWater(20));
            garbageModule.Verify(gm => gm.InsertGarbage(10));
            coffeeModule.Verify(cm => cm.TakeCoffee(20));
        }
    }
}
