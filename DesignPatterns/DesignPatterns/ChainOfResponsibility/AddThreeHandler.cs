using System;

namespace DesignPatterns.DesignPatterns.ChainOfResponsibility
{
    class AddThreeHandler : Handler
    {
        public override void Handle(int value)
        {
            Console.WriteLine("Adding 3 to value");
            value += 3;
            Console.WriteLine($"Current value: {value}");
            base.Handle(value);
        }
    }
}
