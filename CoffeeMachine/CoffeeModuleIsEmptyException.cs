using System;


namespace CoffeeMachine
{
    [Serializable]
    public class CoffeeModuleIsEmptyException : Exception
    {
        public CoffeeModuleIsEmptyException() { }

        public CoffeeModuleIsEmptyException(string message) :base(message) { }

        public CoffeeModuleIsEmptyException(string message, Exception inner) :base(message,inner) { }

        protected CoffeeModuleIsEmptyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
