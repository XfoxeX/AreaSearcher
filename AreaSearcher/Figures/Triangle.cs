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
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentOutOfRangeException("Sides of a triangle cannot be <= 0");

            if (firstSide + secondSide <= thirdSide || firstSide + thirdSide <= secondSide || secondSide + thirdSide <= firstSide)
                throw new ArgumentException("The sum of the lengths of each two sides must be greater than the length of the third side");

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
