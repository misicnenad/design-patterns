using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.Mediator;

namespace DesignPatterns.Factory.Factories
{
    class MediatorFactory : IFactory
    {
        public IDesignPatternExecutor GetExecutor()
        {
            return new MediatorExecutor();
        }
    }
}
