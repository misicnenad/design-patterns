namespace DesignPatterns.DesignPatterns.Visitor.Classic
{
    internal class RedColor : Color
    {
        public RedColor() : base("Red")
        {
        }

        public override string Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
