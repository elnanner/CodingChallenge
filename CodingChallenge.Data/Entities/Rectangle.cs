using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Contracts;
using System;

namespace CodingChallenge.Data.Entities
{
    public class Rectangle : GeometricShape, IGeometricShape
    {

        #region Constrctor

        public Rectangle() { }
        public Rectangle(EGeometricShapes type, decimal side1, decimal? height = 0)
        {
            TypeE = type;
            Side = side1;// corresponde a la base
            Height = (decimal)height;
        }

        #endregion

        #region Properties

        public decimal Height { get; set; }

        #endregion

        #region Public Methods

        public decimal CalculateArea()
        {
            return (Side) * Height;
        }

        public decimal CalculatePerimeter()
        {
            return 2 *  (Side + Height);
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