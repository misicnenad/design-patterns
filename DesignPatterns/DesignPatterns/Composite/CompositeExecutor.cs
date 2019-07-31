using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatterns.Composite
{
    class CompositeExecutor : IDesignPatternExecutor
    {
        public void Execute()
        {
            var sp1 = new SimpleProblem("Write this code");
            var sp2 = new SimpleProblem("Debug this code");
            var cp = new ComplexProblem
            {
                sp1, sp2
            };

            Console.WriteLine(cp.GetProblemSolutionBreakdown());
        }
    }
}
