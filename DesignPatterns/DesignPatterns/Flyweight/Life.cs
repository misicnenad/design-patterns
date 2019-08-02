using System.Collections.Generic;

namespace DesignPatterns.DesignPatterns.Flyweight
{
    static class Life
    {
        private static IDictionary<ProblemType, IProblem> _problems = new Dictionary<ProblemType, IProblem>();

        public static IProblem GetProblem(ProblemType problemType)
        {
            if (_problems.TryGetValue(problemType, out IProblem value))
            {
                return value;
            }

            IProblem problem;
            switch (problemType)
            {
                case ProblemType.BodyImage:
                    problem = new BodyImage();
                    break;
                case ProblemType.Sleep:
                    problem = new Sleep();
                    break;
                default:
                    problem = new Stress();
                    break;
            }

            _problems.Add(problemType, problem);

            return problem;
        }
    }
}
