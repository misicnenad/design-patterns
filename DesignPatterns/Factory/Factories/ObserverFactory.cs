using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.Observer;

namespace DesignPatterns.Factory.Factories
{
    class ObserverFactory : IFactory
    {
        public IDesignPatternExecutor GetExecutor()
        {
            return new ObserverExecutor();
        }
    }
}
