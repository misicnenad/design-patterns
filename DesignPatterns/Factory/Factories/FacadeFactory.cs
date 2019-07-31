using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.Facade;

namespace DesignPatterns.Factory.Factories
{
    class FacadeFactory : IFactory
    {
        public IDesignPatternExecutor GetExecutor()
        {
            return new FacadeExecutor();
        }
    }
}
