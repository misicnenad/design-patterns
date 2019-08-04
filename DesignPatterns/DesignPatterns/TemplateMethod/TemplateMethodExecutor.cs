using System.Collections.Generic;

namespace DesignPatterns.DesignPatterns.TemplateMethod
{
    internal class TemplateMethodExecutor : IDesignPatternExecutor
    {
        public void Execute()
        {
            var problems = new List<Problem>
            {
                new LowLibido(),
                new LowSleepQuality(),
            };

            foreach (var problem in problems)
            {
                problem.SolveProblem();
            }
        }
    }
}
