using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.Facade;

namespace DesignPatterns.Factory.Factories
{
    class FacadeFactory : IFactory
    {
        public IDesignPatternExecutor Prepare()
        {
            return new FacadeExecutor();
        }
    }
}
