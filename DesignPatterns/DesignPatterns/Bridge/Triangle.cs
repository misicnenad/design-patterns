namespace DesignPatterns.DesignPatterns.Bridge
{
    class Triangle : Shape
    {
        public Triangle(IColorer colorer) : base(colorer) { }

        public override string GetDescription()
        {
            return $"{Colorer.GetColor()} triangle";
        }
    }
}
