using System;
using DesignPatterns.DesignPatterns.Visitor.Classic;

namespace DesignPatterns.DesignPatterns.Visitor
{
    internal class VisitorExecutor : IDesignPatternExecutor
    {
        public void Execute()
        {
            Console.WriteLine("Classic Visitor pattern");

            var black = new BlackColor();
            var red = new RedColor();
            var bleacherVisitor = new BleacherVisitor();

            Console.WriteLine(ReturnValue(black, bleacherVisitor));
            Console.WriteLine(ReturnValue(red, bleacherVisitor));

            Console.WriteLine();

            Console.WriteLine("Acyclic Visitor pattern");

            var blackAcyclic = new Acyclic.BlackColor();
            var redAcyclic = new Acyclic.RedColor();
            var bleacherVisitorAcyclic = new Acyclic.BleacherVisitor();

            Console.WriteLine(ReturnValue(blackAcyclic, bleacherVisitorAcyclic));
            Console.WriteLine(ReturnValue(redAcyclic, bleacherVisitorAcyclic));
        }

        private string ReturnValue(Color originalColor, BleacherVisitor visitor)
        {
            return $"{originalColor.Description} => {originalColor.Accept(visitor)}";
        }

        private string ReturnValue(Acyclic.Color originalColor, Acyclic.BleacherVisitor visitor)
        {
            return $"{originalColor.Description} => {originalColor.Accept(visitor)}";
        }
    }
}
