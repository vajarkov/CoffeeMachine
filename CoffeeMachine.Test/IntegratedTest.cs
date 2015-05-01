using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoffeeMachine.Test
{
    [TestClass]
    public class IntegratedTests
    {
        [TestMethod]
        public void IntegrationTest()
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "CoffeeMachine.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.Start();
            var strProc = proc.StandardOutput.ReadLine();
            //Assert.AreEqual("Готов к работе. \n Выберете действие: \n\t 1 - сварить кофе \n\t 2 - насыпать кофе \n\t 3 - налить воды \n\t 4 - очистить жмых\n", strProc);
            Assert.AreEqual("Готов к работе. Выберете действие: 1 - сварить кофе 2 - насыпать кофе 3 - налить воды 4 - очистить жмых", strProc);
            proc.StandardInput.WriteLine("1");
            strProc = proc.StandardOutput.ReadLine();
            Assert.AreEqual("Невозможно сварить кофе: недостаточно кофе", strProc);
            
            proc.StandardInput.WriteLine("2");
            strProc = proc.StandardOutput.ReadLine();
            Assert.AreEqual("Кофе засыпан", strProc);

            proc.StandardInput.WriteLine("1");
            strProc = proc.StandardOutput.ReadLine();
            Assert.AreEqual("Невозможно сварить кофе: недостаточно воды", strProc);

            proc.StandardInput.WriteLine("3");
            strProc = proc.StandardOutput.ReadLine();
            Assert.AreEqual("Вода залита", strProc);
            
            for (int i = 0; i < 4; i++)
            {
                proc.StandardInput.WriteLine("1");
                strProc = proc.StandardOutput.ReadLine();
                Assert.AreEqual("Ваш кофе готов! Выберете действие: 1 - сварить кофе 2 - насыпать кофе 3 - налить воды 4 - очистить жмых", strProc);
            
            }
            proc.StandardInput.WriteLine("1");
            strProc = proc.StandardOutput.ReadLine();
            Assert.AreEqual("Невозможно сварить кофе: Отсек для жмыха переполнен", strProc);

            proc.StandardInput.WriteLine("4");
            strProc = proc.StandardOutput.ReadLine();
            Assert.AreEqual("Отсек для жмыха очищен", strProc);

            proc.StandardInput.WriteLine("1");
            strProc = proc.StandardOutput.ReadLine();
            Assert.AreEqual("Ваш кофе готов! Выберете действие: 1 - сварить кофе 2 - насыпать кофе 3 - налить воды 4 - очистить жмых", strProc);

            proc.StandardInput.WriteLine("0");
            proc.WaitForExit();

            
            
        }
    }
}
