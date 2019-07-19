using DesignPatterns.DesignPatterns.Mediator.Requests;
using System;
using System.Collections.Generic;

namespace DesignPatterns.DesignPatterns.Mediator
{
    class MediatorExecutor : IDesignPatternExecutor
    {
        public void Execute()
        {
            var mediator = new Mediator();
            var request1 = new DoubleValue() { Value = 2 };
            var request2 = new AddValueToList() { List = new List<int> { 2 } };

            var result1 = mediator.Send(request1).GetAwaiter().GetResult();
            var result2 = mediator.Send(request2).GetAwaiter().GetResult();

            Console.WriteLine($"Result1 is: {result1}");
            foreach (var item in result2)
            {
                Console.WriteLine($"Result2 is: {item}");
            }
        }
    }
}
