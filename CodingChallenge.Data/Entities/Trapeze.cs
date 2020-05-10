using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Contracts;
using System;

namespace CodingChallenge.Data.Entities
{
    public class Trapeze : GeometricShape, IGeometricShape
    {
        #region Constrctor

        public Trapeze() { }
        public Trapeze(EGeometricShapes type, decimal side1, decimal? side2 = 0, decimal? base1 = 0, decimal? base2 = 0, decimal? height = 0)
        {
            TypeE = type;
            Side = side1;
            Side2 = (decimal)side2;
            Base1 = (decimal)base1;
            Base2 = (decimal)base2;
            Height = (decimal)height;
        }

        #endregion

        #region Properties
        public decimal Side2 { get; set; }
        public decimal Base1 { get; set; }
        public decimal Base2 { get; set; }
        public decimal Height { get; set; }
        #endregion

        #region Public Methods

        public decimal CalculateArea()
        {
            return Height * ((Base1 + Base2) / 2);
        }

        public decimal CalculatePerimeter()
        {
            return Base1 + Base2 + Side + Side2;
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