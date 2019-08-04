using System;

namespace DesignPatterns.DesignPatterns.TemplateMethod
{
    internal abstract class Problem
    {
        protected Problem(string description)
        {
            Description = description;
        }

        public string Description { get; }
        public abstract string Solution { get; }
        public abstract int WeeksToSolve { get; }

        public void SolveProblem()
        {
            var weeksString = WeeksToSolve == 1 ? "week" : "weeks";
            Console.WriteLine($"To solve the {Description.ToLower()} just {Solution.ToLower()}. " +
                $"The solution will probably take {WeeksToSolve} {weeksString}.");
        }
    }
}
