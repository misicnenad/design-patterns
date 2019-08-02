namespace DesignPatterns.DesignPatterns.Flyweight
{
    interface IProblem
    {
        string Description { get; }
        Difficulty Difficulty { get; }
    }
}
