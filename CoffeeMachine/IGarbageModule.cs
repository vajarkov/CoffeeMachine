﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public interface IGarbageModule
    {
        void TakeGarbage(int units);
        void FillGarbage(int units);
    }
}
