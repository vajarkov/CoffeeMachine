using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CoffeeMachine.Test
{
    /// <summary>
    /// Summary description for MainModuleTest
    /// </summary>
    [TestClass]
    public class MainModuleTest
    {
        public MainModuleTest()
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

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void FillWaterTest()
        {
            /*
            // Создаем mock-объект
            var waterModule = new Mock<IWaterModule>();
            var coffeeModule = new Mock<ICoffeeModule>();
            var garbageModule = new Mock<IGarbageModule>();
            // Создаем тестируемый объект и передаем ему зависимость - mock-объект
            var mainModule = new MainModule(waterModule.Object, garbageModule.Object, coffeeModule.Object);
            // Вызываем метод, который мы тестируем
            mainModule.FillWater();
            waterModule.Verify(wm => wm.FillWater());*/
        }
    }
}
