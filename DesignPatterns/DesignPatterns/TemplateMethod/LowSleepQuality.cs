namespace DesignPatterns.DesignPatterns.TemplateMethod
{
    internal class LowSleepQuality : Problem
    {
        public LowSleepQuality() : base("Low sleep quality") { }

        public override string Solution => "eat healthy, exercise, get enough sunlight, sleep when 'sleepy', go to sleep and wake up at approximately the same time every day";

        public override int WeeksToSolve => 4;
    }
}
