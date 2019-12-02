namespace DesignPatterns.DesignPatterns.Visitor.Acyclic
{
    internal class BlackColor : Color
    {
        public BlackColor() : base("Black")
        {
        }

        public override string Accept(IVisitor visitor)
        {
            if (visitor is IVisitor<BlackColor> typed)
            {
                return typed.Visit(this);
            }

            return string.Empty;
        }
    }
}
