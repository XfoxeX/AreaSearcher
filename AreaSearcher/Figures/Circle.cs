using System;

namespace AreaSearcher.Figures
{
    public class Circle : Figure
    {
        public float Radius { get; }

        public Circle(float radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Radius of a circle cannot be <= 0");

            Radius = radius;
        }
    }
}
