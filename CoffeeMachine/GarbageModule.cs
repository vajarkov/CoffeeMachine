using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    class GarbageModule
    {
        private int garbageLevel = 0;

        public void Fill()
        {
            this.garbageLevel += 200;
        }

        public void FillGarbage()
        {
            this.garbageLevel += 50;
        }

        public void TakeGarbage(int units)
        {
            this.garbageLevel -= units;
        }

        public void FillGarbage(int units)
        {
            this.garbageLevel += units;
        }
    }
}
