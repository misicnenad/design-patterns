using System;

namespace DesignPatterns.DesignPatterns.Prototype
{
    [Serializable]
    class Person
    {
        public string FirstName;
        public string LastName;
        public Person Relative;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}{Environment.NewLine}Relative: {Relative}{Environment.NewLine}";
        }
    }
}
