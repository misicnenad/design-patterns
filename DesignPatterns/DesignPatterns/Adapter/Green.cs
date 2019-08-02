using System;

namespace DesignPatterns.DesignPatterns.Adapter
{
    class Green
    {
        public Green(decimal opacity)
        {
            Opacity = opacity < 0 || opacity > 1.0m 
                ? throw new ArgumentOutOfRangeException($"{nameof(Opacity)} must have a value in the range of 0.0-1.0", nameof(opacity))
                : opacity;
        }

        public decimal Opacity { get; }
    }
}
