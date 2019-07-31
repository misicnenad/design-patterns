using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatterns.Composite
{
    class SimpleProblem : IProblem
    {
        readonly string description;

        public SimpleProblem(string description)
        {
            this.description = description;
        }

        public IEnumerator<IProblem> GetEnumerator()
        {
            yield return this;
        }

        public string GetProblemSolutionBreakdown()
        {
            return $"Solve \"{description}\"";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
