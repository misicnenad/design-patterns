using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatterns.Composite
{
    class ComplexProblem : List<IProblem>, IProblem
    {
        public string GetProblemSolutionBreakdown()
        {
            var ret = new StringBuilder();
            ForEach(p => ret.AppendLine(p.GetProblemSolutionBreakdown()));
            return ret.ToString();
        }
    }
}
