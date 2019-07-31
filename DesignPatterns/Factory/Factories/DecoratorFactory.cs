using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.Decorator;

namespace DesignPatterns.Factory.Factories
{
    class DecoratorFactory : IFactory
    {
        public IDesignPatternExecutor GetExecutor()
        {
            return new DecoratorExecutor();
        }
    }
}
