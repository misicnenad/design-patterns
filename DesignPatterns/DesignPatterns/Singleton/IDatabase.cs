namespace DesignPatterns.DesignPatterns.Singleton
{
    interface IDatabase
    {
        int GetById(string id);
        bool Add(string id, int value);
    }
}
