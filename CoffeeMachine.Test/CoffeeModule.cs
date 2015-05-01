using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoffeeMachine.Test
{
    [TestClass]
    public class CoffeeModuleTests
    {
        [TestMethod]
        public void CoffeeModuleTest()
        {
            var coffeeModule = new CoffeeModule();
            //перед тестом наполним отсек водой
            coffeeModule.FillCoffee();
            // Модуль содержит 200 единиц воды, "выливаем ее"
            coffeeModule.TakeCoffee(40);
            coffeeModule.TakeCoffee(40);
            coffeeModule.TakeCoffee(40);
            coffeeModule.TakeCoffee(40);
            coffeeModule.TakeCoffee(40);

            try
            {
                // Из пустого уже не выльешь
                coffeeModule.TakeCoffee(40);

                // Если мы дошли сюда, значит исключения не возникло. А должно было
                Assert.Fail("CoffeeModuleIsEmptyException is excepted");
            }
            catch (CoffeeModuleIsEmptyException)
            {
                // Ожидаемое исключение. Все хорошо
            }
            catch (Exception)
            {
                // Неожиданное исключение. Что-то пошло не так
                Assert.Fail("CoffeeModuleIsEmptyException is excepted");
            }

            // После наполнения из модуля сново должно выливаться 50 единиц воды
            coffeeModule.FillCoffee();
            coffeeModule.TakeCoffee(40);
            coffeeModule.TakeCoffee(40);
            coffeeModule.TakeCoffee(40);
            coffeeModule.TakeCoffee(40);
            coffeeModule.TakeCoffee(40);
        }
    }
}
