using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Contracts;
using System;

namespace CodingChallenge.Data.Entities
{
    public class Circle : GeometricShape, IGeometricShape
    {
        public Circle(EGeometricShapes type, decimal side1)
        {
            TypeE = type;
            Side = side1;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        #region Methods

        private decimal GetRatio()
        {
            return Side / 2;
        }
        public decimal CalculateArea()
        {
            decimal ratio = this.GetRatio();
            return Convert.ToDecimal((decimal)Math.PI * (ratio * ratio));
        }

        public decimal CalculatePerimeter()
        {
            return Convert.ToDecimal((decimal)Math.PI * Side);
        }

        public EGeometricShapes GetTypeE()
        {
            return TypeE;
        }

        #endregion
    }
}