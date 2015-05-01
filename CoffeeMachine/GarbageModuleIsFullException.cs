using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class GarbageModuleIsFullException : Exception
    {
        public GarbageModuleIsFullException() { }

        public GarbageModuleIsFullException(string message) :base(message) { }

        public GarbageModuleIsFullException(string message, Exception inner) :base(message,inner) { }

        protected GarbageModuleIsFullException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
