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
            if ((this.garbageLevel == 40) && (units > 0))
            {
                var exception = new GarbageModuleIsFullException("Резервуар пуст!!!");
                throw exception;
            }
            this.garbageLevel += units;
        }

        public int GarbageLevel
        {
            get;
            private set;
        }
    }
}
