using System;

namespace DesignPatterns.DesignPatterns.ChainOfResponsibility
{
    class SubtractOneHandler : Handler
    {
        public override void Handle(int value)
        {
            Console.WriteLine("Subtracting 1 from value");
            value -= 1;
            Console.WriteLine($"Current value: {value}");
            base.Handle(value);
        }
    }
}
