using System;

namespace DesignPatterns.DesignPatterns.Decorator
{
    class DecoratorExecutor : IDesignPatternExecutor
    {
        public void Execute()
        {
            var device = new GPU(new Monitor(new RAM(new Motherboard(), 4)));
            Console.WriteLine(device.GetFinalDescription());
        }
    }
}
