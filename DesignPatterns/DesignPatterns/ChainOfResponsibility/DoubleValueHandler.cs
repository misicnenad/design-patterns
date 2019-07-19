using System;

namespace DesignPatterns.DesignPatterns.ChainOfResponsibility
{
    class DoubleValueHandler : Handler
    {
        public override void Handle(int value)
        {
            Console.WriteLine("Doubling value");
            value *= 2;
            Console.WriteLine($"Current value: {value}");
            base.Handle(value);
        }
    }
}
