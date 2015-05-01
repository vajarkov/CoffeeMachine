using System;

namespace CoffeeMachine
{
    public class CoffeeModule : ICoffeeModule
    {
        private int _coffeeLevel=0;

        public void FillCoffee()
        {
            this._coffeeLevel += 200;
        }

        public void TakeCoffee(int units)
        {
            if ((this._coffeeLevel == 0) && (units > 0))
            {
                var exception = new CoffeeModuleIsEmptyException("Резервуар пуст!!!");
                throw exception;
            }
            this._coffeeLevel -= units;
        }

        
        public int CoffeeLevel
        {
            get;
            private set;
        }
    }
}
