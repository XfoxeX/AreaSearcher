using System;

namespace AreaSearcher.Figures
{
    public class Triangle : Figure
    {
        public float FirstSide { get; }
        public float SecondSide { get; }
        public float ThirdSide { get; }

        public Triangle(float firstSide, float secondSide, float thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        /// <summary>
        /// Checking a triangle for a right triangle
        /// </summary>
        public bool IsRightTriangle()
        {
            if ((Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2) == Math.Pow(ThirdSide, 2)) || (Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2) == Math.Pow(SecondSide, 2)) || (Math.Pow(ThirdSide, 2) + Math.Pow(SecondSide, 2) == Math.Pow(FirstSide, 2)))
                return true;

            return false;
        }
    }
}
