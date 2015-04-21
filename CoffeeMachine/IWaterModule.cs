﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public interface IWaterModule
    {
        void FillWater(int units);
        void TakeWater(int units);
    }
}
