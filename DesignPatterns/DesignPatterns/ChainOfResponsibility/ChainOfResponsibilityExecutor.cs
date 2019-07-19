using System;

namespace DesignPatterns.DesignPatterns.ChainOfResponsibility
{
    class ChainOfResponsibilityExecutor : IDesignPatternExecutor
    {
        public void Execute()
        {
            var value = 0;
            Console.WriteLine($"Initial value {value}");
            var rootHandler = new AddThreeHandler();
            rootHandler.Add(new SubtractOneHandler());
            rootHandler.Add(new DoubleValueHandler());

            rootHandler.Handle(value);
        }
    }
}
