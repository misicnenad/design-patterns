using DesignPatterns.DesignPatterns;

namespace DesignPatterns.Factory.Factories
{
    interface IFactory
    {
        IDesignPatternExecutor GetExecutor();
    }
}
