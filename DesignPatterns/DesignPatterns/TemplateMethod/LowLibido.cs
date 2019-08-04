namespace DesignPatterns.DesignPatterns.TemplateMethod
{
    internal class LowLibido : Problem
    {
        public LowLibido() : base("Chronically low libido") { }

        public override string Solution => "eat healthy, exercise, hit on girls, spend time with girls you like";

        public override int WeeksToSolve => 12;
    }
}
