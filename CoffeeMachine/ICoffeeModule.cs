using System;


namespace CoffeeMachine
{
    public interface ICoffeeModule
    {
        void FillCoffee();
        void TakeCoffee(int units);
    }
}
