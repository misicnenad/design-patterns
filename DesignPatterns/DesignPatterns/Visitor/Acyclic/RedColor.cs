namespace DesignPatterns.DesignPatterns.Visitor.Acyclic
{
    internal class RedColor : Color
    {
        public RedColor() : base("Red")
        {
        }

        public override string Accept(IVisitor visitor)
        {
            if (visitor is IVisitor<RedColor> typed)
            {
                return typed.Visit(this);
            }

            return string.Empty;
        }
    }
}
