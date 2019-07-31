using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.Composite;

namespace DesignPatterns.Factory.Factories
{
    class CompositeFactory : IFactory
    {
        public IDesignPatternExecutor GetExecutor()
        {
            return new CompositeExecutor();
        }
    }
}
