using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.ChainOfResponsibility;

namespace DesignPatterns.Factory.Factories
{
    class ChainOfResponsibilityFactory : IFactory
    {
        public IDesignPatternExecutor GetExecutor()
        {
            return new ChainOfResponsibilityExecutor();
        }
    }
}
