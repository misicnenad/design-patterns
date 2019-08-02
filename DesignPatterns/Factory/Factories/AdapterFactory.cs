using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.Adapter;

namespace DesignPatterns.Factory.Factories
{
    class AdapterFactory : IFactory
    {
        public IDesignPatternExecutor GetExecutor()
        {
            return new AdapterExecutor();
        }
    }
}
