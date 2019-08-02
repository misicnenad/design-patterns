using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.Flyweight;

namespace DesignPatterns.Factory.Factories
{
    class FlyweightFactory : IFactory
    {
        public IDesignPatternExecutor GetExecutor()
        {
            return new FlyweightExecutor();
        }
    }
}
