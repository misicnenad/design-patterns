namespace DesignPatterns.DesignPatterns.Decorator
{
    class Motherboard : Device
    {
        internal override string GetFinalDescription()
        {
            return "This device contains a motherboard";
        }
    }
}
