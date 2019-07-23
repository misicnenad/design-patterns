using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.Prototype;

namespace DesignPatterns.Factory.Factories
{
    class PrototypeFactory : IFactory
    {
        public IDesignPatternExecutor Prepare()
        {
            return new PrototypeExecutor();
        }
    }
}
