using Ninject.Modules;

namespace CoffeeMachine
{
    public class MainModuleNinject : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IWaterModule>().To<WaterModule>();
            this.Bind<ICoffeeModule>().To<CoffeeModule>();
            this.Bind<IGarbageModule>().To<GarbageModule>();
            this.Bind<MainModule>().To<MainModule>();
        }
    }
}
