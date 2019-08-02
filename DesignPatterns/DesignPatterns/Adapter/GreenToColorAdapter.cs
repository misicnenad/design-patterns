using System;

namespace DesignPatterns.DesignPatterns.Adapter
{
    class GreenToColorAdapter : IColor
    {
        public GreenToColorAdapter(Green green)
        {
            Red = 0;
            Green = 255;
            Blue = 0;
            Opacity = green.Opacity;
        }

        public int Red { get; }

        public int Green { get; }

        public int Blue { get; }

        public decimal Opacity { get; }

        public override string ToString()
        {
            return $"Red: {Red}{Environment.NewLine}" +
                   $"Green: {Green}{Environment.NewLine}" +
                   $"Blue: {Blue}{Environment.NewLine}" +
                   $"Opacity: {Opacity}";
        }
    }
}
