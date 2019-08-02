namespace DesignPatterns.DesignPatterns.Flyweight
{
    class Stress : GenericProblem
    {
        public override string Description => "Too much stress";
        public override Difficulty Difficulty => Difficulty.Hard;
    }
}
