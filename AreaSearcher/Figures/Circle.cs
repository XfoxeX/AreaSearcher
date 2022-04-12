using System;

namespace AreaSearcher.Figures
{
    public class Circle : Figure
    {
        public float Radius { get; }

        public Circle(float radius)
        {
            Radius = radius;
        }
    }
}
