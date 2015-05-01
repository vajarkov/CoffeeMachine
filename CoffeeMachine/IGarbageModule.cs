using System;


namespace CoffeeMachine
{
    public interface IGarbageModule
    {
        void InsertGarbage(int units);
        void Clear();
    }
}
