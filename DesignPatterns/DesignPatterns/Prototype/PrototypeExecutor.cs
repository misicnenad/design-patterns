using System;

namespace DesignPatterns.DesignPatterns.Prototype
{
    class PrototypeExecutor : IDesignPatternExecutor
    {
        public void Execute()
        {
            Console.WriteLine("Simple reference copy");
            var person1 = new Person("John", "Doe");
            var relative = new Person("Rel", "Ative");
            person1.Relative = relative;
            var person2 = person1;
            Console.WriteLine("Before change");
            Console.WriteLine($"Person1: {person1}");
            Console.WriteLine($"Person2: {person2}");
            person2.FirstName = "Dave";
            person2.Relative.FirstName = "Change";
            Console.WriteLine("After copying and changing person2.FirstName to 'Dave'");
            Console.WriteLine($"Person1: {person1}");
            Console.WriteLine($"Person2: {person2}");

            Console.WriteLine("Deep copy");
            var person3 = new Person("Deep", "Copy");
            var relative2 = new Person("New", "Relative");
            person3.Relative = relative2;
            var person4 = person3.DeepCopy();
            Console.WriteLine("Before change");
            Console.WriteLine($"Person3: {person3}");
            Console.WriteLine($"Person4: {person4}");
            person4.FirstName = "Dave";
            person4.Relative.FirstName = "Change";
            Console.WriteLine("After deep copying and changing person4.FirstName to 'Dave'");
            Console.WriteLine($"Person3: {person3}");
            Console.WriteLine($"Person4: {person4}");
        }
    }
}
