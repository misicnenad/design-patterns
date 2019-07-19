namespace DesignPatterns.DesignPatterns.Bridge
{
    abstract class Shape
    {
        protected IColorer Colorer { get; set; }

        public Shape(IColorer colorer)
        {
            Colorer = colorer;
        }

        public abstract string GetDescription();
    }
}
