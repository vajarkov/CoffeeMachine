using System;


namespace CoffeeMachine
{
    public interface IWaterModule
    {
        void FillWater();
        void TakeWater(int units);
    }
}
