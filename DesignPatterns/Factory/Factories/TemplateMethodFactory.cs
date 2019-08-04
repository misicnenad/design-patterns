using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.TemplateMethod;

namespace DesignPatterns.Factory.Factories
{
    internal class TemplateMethodFactory : IFactory
    {
        public IDesignPatternExecutor GetExecutor()
        {
            return new TemplateMethodExecutor();
        }
    }
}
