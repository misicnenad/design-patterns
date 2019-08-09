namespace DesignPatterns.DesignPatterns.Visitor.Acyclic
{
    internal abstract class Color
    {

        protected Color(string description)
        {
            Description = description;
        }

        public string Description { get; }

        public abstract string Accept(IVisitor visitor);
    }
}
