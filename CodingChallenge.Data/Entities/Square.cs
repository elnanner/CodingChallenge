using CodingChallenge.Data.Contracts;
using System;
using CodingChallenge.Data.Classes;

namespace CodingChallenge.Data.Entities
{
    public class Square : GeometricShape, IGeometricShape
    {
        #region Constructor

        public Square() { }
        public Square(EGeometricShapes type, decimal side1)
        {
            TypeE = type;
            Side = side1;
        }
        #endregion

        #region Properties
        public decimal Side { get; set; }
        #endregion
        #region Methods

        public decimal CalculateArea()
        {
            return Side * Side;
        }

        public decimal CalculatePerimeter()
        {
            return Side * 4;
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
        #endregion

    }
}