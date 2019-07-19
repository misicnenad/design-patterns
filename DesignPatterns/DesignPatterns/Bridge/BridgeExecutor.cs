using System;

namespace DesignPatterns.DesignPatterns.Bridge
{
    class BridgeExecutor : IDesignPatternExecutor
    {
        public void Execute()
        {
            Shape shape = new Square(new RedColorer());
            Console.WriteLine(shape.GetDescription());
            shape = new Square(new BlueColorer());
            Console.WriteLine(shape.GetDescription());
            shape = new Triangle(new RedColorer());
            Console.WriteLine(shape.GetDescription());
            shape = new Triangle(new BlueColorer());
            Console.WriteLine(shape.GetDescription());
        }
    }
}
