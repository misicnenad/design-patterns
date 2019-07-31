using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatterns.Composite
{
    interface IProblem : IEnumerable<IProblem>
    {
        string GetProblemSolutionBreakdown();
    }
}
