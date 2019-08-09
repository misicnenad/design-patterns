namespace DesignPatterns.DesignPatterns.Visitor.Classic
{
    internal abstract class Color
    {
        protected Color(string description)
        {
            Description = description;
        }

        internal string Description { get; }
        public abstract string Accept(IVisitor visitor);
    }
}
