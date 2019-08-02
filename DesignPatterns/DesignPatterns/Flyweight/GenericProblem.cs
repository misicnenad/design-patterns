namespace DesignPatterns.DesignPatterns.Flyweight
{
    abstract class GenericProblem : IProblem
    {
        public virtual string Description { get; }

        public virtual Difficulty Difficulty { get; }

        public override string ToString()
        {
            return $"{Description}. Difficulty: {Difficulty}";
        }
    }
}
