using System;
using Moq;
using Ninject;

namespace CoffeeMachine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        public static IKernel AppKernel;

        static void Main()
        {
            AppKernel = new StandardKernel(new MainModuleNinject());
            var mainModule = AppKernel.Get<MainModule>();
            int keyPress=0;
            
            //Console.WriteLine("Готов к работе. \n Выберете действие: \n\t 1 - сварить кофе \n\t 2 - насыпать кофе \n\t 3 - налить воды \n\t 4 - очистить жмых");
            Console.WriteLine("Готов к работе. Выберете действие: 1 - сварить кофе 2 - насыпать кофе 3 - налить воды 4 - очистить жмых");
            while (true)
            {
                int.TryParse(Console.ReadLine(), out keyPress);
                //int.TryParse(Console.ReadKey().KeyChar.ToString(), out keyPress);
                //Console.WriteLine();
                switch(keyPress)
                {
                    case 0:
                        Console.WriteLine("Кофеварка сломалась! Валим!");
                        Console.ReadKey();
                        break;
                    case 1:
                        try
                        {
                            mainModule.MakeCoffee();
                        }
                        catch (CoffeeModuleIsEmptyException)
                        {
                            Console.WriteLine("Невозможно сварить кофе: недостаточно кофе");
                            break;
                        }
                        catch (WaterModuleIsEmptyException)
                        {
                            Console.WriteLine("Невозможно сварить кофе: недостаточно воды");
                            break;
                        }
                        catch (GarbageModuleIsFullException)
                        {
                            Console.WriteLine("Невозможно сварить кофе: Отсек для жмыха переполнен");
                            break;
                        }
                        Console.WriteLine("Ваш кофе готов! Выберете действие: 1 - сварить кофе 2 - насыпать кофе 3 - налить воды 4 - очистить жмых");
                        //Console.WriteLine("Ваш кофе готов! \n Выберете действие: \n\t 1 - сварить кофе \n\t 2 - насыпать кофе \n\t 3 - налить воды \n\t 4 - очистить жмых");
                        break;
                    case 2:
                        mainModule.FillCoffee();
                        Console.WriteLine("Кофе засыпан");
                        break;
                    case 3:
                        mainModule.FillWater();
                        Console.WriteLine("Вода залита");
                        break;
                    case 4:
                        mainModule.Clear();
                        Console.WriteLine("Отсек для жмыха очищен");
                        break;
                    default:
                        Console.WriteLine("Готов к работе. \n Выберете действие: \n\t 1 - сварить кофе \n\t 2 - насыпать кофе \n\t 3 - налить воды \n\t 4 - очистить жмых");
                        break;
                }
                if (keyPress == 0)
                    break;
            }
            Environment.Exit(0);

        }
    }
}
