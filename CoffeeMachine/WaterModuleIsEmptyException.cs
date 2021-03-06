﻿using System;


namespace CoffeeMachine
{
    [Serializable]
    public class WaterModuleIsEmptyException : Exception
    {
        public WaterModuleIsEmptyException() { }

        public WaterModuleIsEmptyException(string message) :base(message) { }

        public WaterModuleIsEmptyException(string message, Exception inner) :base(message,inner) { }

        protected WaterModuleIsEmptyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
