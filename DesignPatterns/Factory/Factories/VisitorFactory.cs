using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.Visitor;

namespace DesignPatterns.Factory.Factories
{
    internal class VisitorFactory : IFactory
    {
        public IDesignPatternExecutor GetExecutor()
        {
            return new VisitorExecutor();
        }
    }
}
