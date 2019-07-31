using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.Builder;

namespace DesignPatterns.Factory.Factories
{
    class BuilderFactory : IFactory
    {
        public IDesignPatternExecutor GetExecutor()
        {
            return new BuilderExecutor();
        }
    }
}
