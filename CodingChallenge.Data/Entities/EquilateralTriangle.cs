using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Contracts;
using System;

namespace CodingChallenge.Data.Entities
{
    public class EquilateralTriangle : GeometricShape, IGeometricShape
    {
        public EquilateralTriangle() { }
        public EquilateralTriangle(EGeometricShapes type)
        {
            TypeE = type;
        }
        public decimal CalculateArea()
        {
            throw new NotImplementedException();
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

        public EGeometricShapes GetTypeE()
        {
            throw new NotImplementedException();
        }

        public void SetSide(decimal side)
        {
            throw new NotImplementedException();
        }

    }
}