using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    class CoffeeModule
    {
        private int coffeeLevel=0;

        public void Fill()
        {
            this.coffeeLevel += 200;
        }

        public void FillCoffee()
        {
            this.coffeeLevel += 50;
        }

        public void TakeCoffee(int units)
        {
            this.coffeeLevel -= units;
        }

        public void FillCoffee(int units)
        {
            this.coffeeLevel += units;
        }
    }
}
