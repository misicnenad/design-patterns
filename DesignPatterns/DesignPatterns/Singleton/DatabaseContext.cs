using System;

namespace DesignPatterns.DesignPatterns.Singleton
{
    class DatabaseContext
    {
        IDatabase _database;

        public DatabaseContext(IDatabase database)
        {
            _database = database ?? throw new ArgumentNullException(nameof(database));
        }

        public int GetById(string id)
        {
            return _database.GetById(id);
        }

        public bool Add(string id, int value)
        {
            return _database.Add(id, value);
        }
    }
}
