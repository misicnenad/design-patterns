namespace DesignPatterns.DesignPatterns.Visitor.Acyclic
{
    internal class BleacherVisitor : IVisitor,
        IVisitor<BlackColor>,
        IVisitor<RedColor>
    {

        public string Visit(BlackColor visitable)
        {
            return "Grey";
        }

        public string Visit(RedColor visitable)
        {
            return "Pink";
        }
    }
}
