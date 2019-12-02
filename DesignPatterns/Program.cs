using DesignPatterns.Factory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new DesignPatternFactory();
            var dpTypes = GetDesignPatternTypes(factory);
            
            OutputDesignPatternTypes(dpTypes);

            var designPatternType = ReadDesignPatternFromUser(dpTypes);

            var pattern = factory.GetDesignPattern(designPatternType);
            pattern.Execute();

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        private static IDictionary<int, string> GetDesignPatternTypes(DesignPatternFactory factory)
        {
            var dpTypes = new Dictionary<int, string>();

            var names = factory.GetDesignPatternTypes();
            for (var i = 0; i < names.Count; i++)
            {
                dpTypes.TryAdd(i, names.ElementAt(i));
            }

            return dpTypes;
        }

        private static void OutputDesignPatternTypes(IDictionary<int, string> dpTypes)
        {
            Console.WriteLine("Design Pattern IDs:");
            foreach (var type in dpTypes)
            {
                Console.WriteLine($"{type.Value}: {type.Key}");
            }
        }

        private static string ReadDesignPatternFromUser(IDictionary<int, string> dpTypes)
        {
            var designPattern = "";
            while (!int.TryParse(designPattern, out int id) || !dpTypes.ContainsKey(id))
            {
                Console.Write("Enter design pattern ID to show: ");
                designPattern = Console.ReadLine();
            }
            Console.WriteLine();

            return dpTypes[int.Parse(designPattern)];
        }
    }
}
