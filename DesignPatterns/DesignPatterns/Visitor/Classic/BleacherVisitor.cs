namespace DesignPatterns.DesignPatterns.Visitor.Classic
{
    internal class BleacherVisitor : IVisitor
    {
        public string Visit(BlackColor blackColor)
        {
            return "Grey";
        }

        public string Visit(RedColor redColor)
        {
            return "Pink";
        }
    }
}
