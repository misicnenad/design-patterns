namespace DesignPatterns.DesignPatterns.Visitor.Classic
{
    internal interface IVisitor
    {
        string Visit(BlackColor blackColor);
        string Visit(RedColor redColor);
    }
}
