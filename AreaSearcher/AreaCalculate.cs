using System;
using AreaSearcher.Figures;

namespace AreaSearcher
{
    /// <summary>
    /// Calculating the area of a figure
    /// </summary>
    public static class AreaCalculate
    {
        // Calculating the area without knowledge of figure type

        /// <summary>
        /// Сalculating the area of a circle
        /// </summary>
        public static float CulcArea(float radius)
        {
            return (float)(Math.Pow(radius, 2) * Math.PI);
        }

        /// <summary>
        /// Сalculating the area of a triangle
        /// </summary>
        public static float CulcArea(float a, float b, float c)
        {
            // Triangle perimeter
            float p = (a + b + c) / 2;

            return (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // Calculating the area of a certain figure

        /// <summary>
        /// Сalculating the area of a circle
        /// </summary>
        public static float CulcArea(Circle circle)
        {
            return CulcArea(circle.Radius);
        }

        /// <summary>
        /// Сalculating the area of a triangle
        /// </summary>
        public static float CulcArea(Triangle triangle)
        {
            return CulcArea(triangle.FirstSide, triangle.SecondSide, triangle.ThirdSide);
        }
    }
}