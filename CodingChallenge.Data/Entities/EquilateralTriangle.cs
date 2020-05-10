using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Contracts;
using System;

namespace CodingChallenge.Data.Entities
{
    public class EquilateralTriangle : GeometricShape, IGeometricShape
    {
       #region Constructor
        public EquilateralTriangle() { }
        public EquilateralTriangle(EGeometricShapes type, decimal side1)
        {
            TypeE = type;
            Side = side1;
        }
        #endregion

        #region Public Methods

        public decimal CalculateArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * Side * Side;
        }

        public decimal CalculatePerimeter()
        {
            return Side * 3;
        }

        public EGeometricShapes GetTypeE()
        {
            return TypeE;
        }
        public decimal GetArea()
        {
            return this.CalculateArea();
        }

        public decimal GetPerimeter()
        {
            return this.CalculatePerimeter();
        }
        //public void SetBase1(decimal base1)
        //{
        //    throw new NotImplementedException();
        //}

        //public void SetBase2(decimal base2)
        //{
        //    throw new NotImplementedException();
        //}

        //public void SetHeight(decimal height)
        //{
        //    throw new NotImplementedException();
        //}

        //public void SetSide1(decimal side1)
        //{
        //    throw new NotImplementedException();
        //}

        //public void SetSide2(decimal side2)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion
    }
}