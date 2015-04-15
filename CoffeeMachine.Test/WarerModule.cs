using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CoffeeMachine.Test
{
    [TestClass]
    public class WarerModule
    {
        [TestMethod]
        public void WaterModuleTest()
        {
            var waterModule = new WaterModule();
            //перед тестом наполним отсек водой
            waterModule.Fill();
            // Модуль содержит 200 единиц воды, "выливаем ее"
            waterModule.TakeWater(40);
            waterModule.TakeWater(40);
            waterModule.TakeWater(40);
            waterModule.TakeWater(40);
            waterModule.TakeWater(40);

            try
            {
                // Из пустого уже не выльешь
                waterModule.TakeWater(40);

                // Если мы дошли сюда, значит исключения не возникло. А должно было
                Assert.Fail("WaterModuleIsEmptyException is excepted");
            }
            catch (WaterModuleIsEmptyException)
            {
                // Ожидаемое исключение. Все хорошо
            }
            catch (Exception)
            {
                // Неожиданное исключение. Что-то пошло не так
                Assert.Fail("WaterModuleIsEmptyException is excepted");
            }

            // После наполнения из модуля сново должно выливаться 50 единиц воды
            waterModule.FillWater();
            waterModule.TakeWater(40);
            waterModule.TakeWater(40);
            waterModule.TakeWater(40);
            waterModule.TakeWater(40);
            waterModule.TakeWater(40);
        }
    }
}
