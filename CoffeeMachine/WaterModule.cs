using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class WaterModule : IWaterModule
    {
        private int waterLevel=0;
        
        public void Fill()
        {
            this.waterLevel += 200;
        }

        public void FillWater()
        {
            this.waterLevel += 50;
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

        public void FillWater(int units)
        {
            this.waterLevel += units;
        }

        public int WaterLevel
        {
            get {
                return this.waterLevel;
            }
        }
    }
}
