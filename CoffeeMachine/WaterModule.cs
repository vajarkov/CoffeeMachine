using System;


namespace CoffeeMachine
{
    public class WaterModule : IWaterModule
    {
        private int waterLevel=0;
        
        public void FillWater()
        {
            this.waterLevel += 200;
        }

        public void TakeWater(int units)
        {
            if ((this.waterLevel==0)&&(units>0))
            {
                var exception = new WaterModuleIsEmptyException("Резервуар пуст!!!");
                throw exception;
            }
            this.waterLevel -= units;
        }

        public int WaterLevel
        {
            get;
            private set;
        }
    }
}
