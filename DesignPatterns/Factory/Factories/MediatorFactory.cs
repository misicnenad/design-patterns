using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.Mediator;

namespace DesignPatterns.Factory.Factories
{
    class MediatorFactory : IFactory
    {
        public IDesignPatternExecutor Prepare()
        {
            return new MediatorExecutor();
        }
    }
}
