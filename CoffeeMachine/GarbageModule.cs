using System;


namespace CoffeeMachine
{
    public class GarbageModule: IGarbageModule 
    {
        private int garbageLevel = 0;

        public void Clear()
        {
            this.garbageLevel = 0;
        }

        public void InsertGarbage(int units)
        {
            this.garbageLevel += units;
        }
    }
}
