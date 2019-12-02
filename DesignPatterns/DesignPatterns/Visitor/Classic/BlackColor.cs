namespace DesignPatterns.DesignPatterns.Visitor.Classic
{
    internal class BlackColor : Color
    {
        public BlackColor() : base("Black")
        {
        }

        public override string Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
