using DesignPatterns.DesignPatterns;
using DesignPatterns.Factory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Factory
{
    class DesignPatternFactory
    {

        ICollection<Tuple<string, IFactory>> _factories = new List<Tuple<string, IFactory>>();

        public DesignPatternFactory()
        {
            foreach (var t in typeof(DesignPatternFactory).Assembly.GetTypes())
            {
                if (typeof(IFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    _factories.Add(Tuple.Create(
                        t.Name.Replace("Factory", string.Empty),
                        (IFactory)Activator.CreateInstance(t)
                        ));
                }
            }
        }

        internal ICollection<string> GetDesignPatternTypes()
        {
            return _factories.Select(f => f.Item1).ToList();
        }

        internal IDesignPatternExecutor GetDesignPattern(string designPattern)
        {
            return _factories
                .Where(f => f.Item1 == designPattern)
                .SingleOrDefault()?
                .Item2
                .Prepare();
        }
    }
}
