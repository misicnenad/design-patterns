using System;

namespace DesignPatterns.DesignPatterns.Singleton
{
    class SingletonExecutor : IDesignPatternExecutor
    {
        public void Execute()
        {
            var context1 = new DatabaseContext(CityDatabase.Instance);
            Console.WriteLine("context1, Novi Sad " + context1.GetById("Novi Sad"));
            context1.Add("Nis", 260000);
            Console.WriteLine("context1, Nis " + context1.GetById("Nis"));

            var context2 = new DatabaseContext(CityDatabase.Instance);
            Console.WriteLine("context2, Nis " + context2.GetById("Nis"));
        }
    }
}
