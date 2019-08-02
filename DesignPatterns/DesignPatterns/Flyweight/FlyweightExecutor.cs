using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatterns.Flyweight
{
    class FlyweightExecutor : IDesignPatternExecutor
    {
        public void Execute()
        {
            Console.WriteLine(Life.GetProblem(ProblemType.Sleep));
            Console.WriteLine(Life.GetProblem(ProblemType.Stress));
            Console.WriteLine(Life.GetProblem(ProblemType.BodyImage));
        }
    }
}
