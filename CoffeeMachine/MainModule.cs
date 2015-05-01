using System;


namespace CoffeeMachine
{
    
    public class MainModule 
    {
        private ICoffeeModule _coffeeModule;
        private IWaterModule _waterModule;
        private IGarbageModule _garbageModule;

        public MainModule(IWaterModule wm, IGarbageModule gm, ICoffeeModule cm)
        {
            _coffeeModule = cm;
            _waterModule = wm;
            _garbageModule = gm;
        }

        public void FillWater()
        {
            _waterModule.FillWater();
        }

        public void FillCoffee()
        {
            _coffeeModule.FillCoffee();
        }

        public void Clear()
        {
            _garbageModule.Clear();
        }
    }
}
