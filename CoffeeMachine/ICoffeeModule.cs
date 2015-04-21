using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public interface ICoffeeModule
    {
        void FillCoffee(int units);
        void TakeCoffee(int units);
    }
}
