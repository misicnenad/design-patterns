using System;
using System.Collections.Generic;

namespace DesignPatterns.DesignPatterns.Singleton
{
    class CityDatabase : IDatabase
    {
        IDictionary<string, int> _cityPopulations;
        public static CityDatabase Instance => _instance.Value;

        static Lazy<CityDatabase> _instance = new Lazy<CityDatabase>(() => new CityDatabase());

        private CityDatabase()
        {
            _cityPopulations = new Dictionary<string, int>
            {
                { "Novi Sad", 300000 },
                { "Becej", 25000 },
                { "Beograd", 1500000 }
            };
        }

        public bool Add(string city, int population)
        {
            return _cityPopulations.TryAdd(city, population);
        }

        public int GetById(string city)
        {
            if (_cityPopulations.TryGetValue(city, out int population))
            {
                return population;
            }

            return -1;
        }
    }
}
