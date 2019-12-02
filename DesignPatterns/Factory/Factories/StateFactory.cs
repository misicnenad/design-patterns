using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.State;

namespace DesignPatterns.Factory.Factories
{
    internal class StateFactory : IFactory
    {
        public IDesignPatternExecutor GetExecutor()
        {
            return new StateExecutor();
        }
    }
}
