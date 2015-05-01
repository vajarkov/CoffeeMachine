using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoffeeMachine.Test
{
    [TestClass]
    public class GarbageModuleTests
    {
        [TestMethod]
        public void GarbageModuleTest()
        {
            var garbageModule = new GarbageModule();
            garbageModule.Clear();
            garbageModule.InsertGarbage(10);
            garbageModule.InsertGarbage(10);
            garbageModule.InsertGarbage(10);
            garbageModule.InsertGarbage(10);
            

            try
            {
                garbageModule.InsertGarbage(10);
                Assert.Fail("GarbageModuleIsFullException is excepted");
            }
            catch(GarbageModuleIsFullException)
            {

            }
            catch(Exception)
            {
                Assert.Fail("GarbageModuleIsFullException is excepted");
            }

            garbageModule.Clear();
            garbageModule.InsertGarbage(10);
            garbageModule.InsertGarbage(10);
            garbageModule.InsertGarbage(10);
            garbageModule.InsertGarbage(10);
   

        }
    }
}
