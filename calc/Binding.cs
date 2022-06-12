using Ninject.Modules;

namespace calc
{
    public class Binding : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserInterface>().To<ConsoleUserInterface>();
            Bind<IVariableStorage>().To<InMemoryVariableStorage>();
        }
    }
}
