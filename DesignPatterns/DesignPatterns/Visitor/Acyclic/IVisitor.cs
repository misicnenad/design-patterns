namespace DesignPatterns.DesignPatterns.Visitor.Acyclic
{
    internal interface IVisitor
    {
    }

    internal interface IVisitor<TVisitable>
    {
        string Visit(TVisitable visitable);
    }
}
