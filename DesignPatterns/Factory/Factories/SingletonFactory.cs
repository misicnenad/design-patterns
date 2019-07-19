using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.Singleton;

namespace DesignPatterns.Factory.Factories
{
    class SingletonFactory : IFactory
    {
        public IDesignPatternExecutor Prepare()
        {
            return new SingletonExecutor();
        }
    }
}
