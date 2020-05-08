using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Contracts;
using System;

namespace CodingChallenge.Data.Entities
{
    public class Circle : GeometricShape, IGeometricShape
    {
        public Circle() { }
        public Circle(EGeometricShapes type)
        {
            TypeE = type;
        }
        public decimal CalculateArea()
        {
            return Convert.ToDecimal((decimal)Math.PI * (side * side));
        }

        public decimal CalculatePerimeter()
        {
            throw new NotImplementedException();
        }

        public decimal GetArea()
        {
            throw new NotImplementedException();
        }

        public decimal GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public void SetSide(decimal side)
        {
            this.side = side;
        }

        public EGeometricShapes GetTypeE()
        {
            return TypeE;
        }

       
    }
}