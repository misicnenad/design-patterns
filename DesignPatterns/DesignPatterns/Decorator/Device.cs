namespace DesignPatterns.DesignPatterns.Decorator
{
    abstract class Device
    {
        abstract internal string GetFinalDescription();

        internal string GetNonFinalDescription()
        {
            return GetFinalDescription().Replace(" and", ", ");
        }
    }
}
