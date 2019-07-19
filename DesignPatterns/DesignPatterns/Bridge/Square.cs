namespace DesignPatterns.DesignPatterns.Bridge
{
    class Square : Shape
    {
        public Square(IColorer colorer) : base(colorer) { }

        public override string GetDescription()
        {
            return $"{Colorer.GetColor()} square";
        }
    }
}
