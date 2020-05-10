using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Entities;
using System;

namespace CodingChallenge.Data.Contracts
{
    public class GeometricShapeFactory
    {
        public static IGeometricShape GetGeometricShape(EGeometricShapes eGeometricShapes, decimal side1, decimal? side2, decimal? base1, decimal? base2, decimal? height ) {
            IGeometricShape _iGeometricShape;

            switch (eGeometricShapes)
            {
                case EGeometricShapes.Circle:
                    _iGeometricShape = new Circle(EGeometricShapes.Circle, side1);
                    break;

                case EGeometricShapes.EquilateralTriangle:
                    _iGeometricShape = new EquilateralTriangle(EGeometricShapes.EquilateralTriangle, side1);
                    break;

                case EGeometricShapes.Square:
                    _iGeometricShape = new Square(EGeometricShapes.Square, side1);
                    break;

                case EGeometricShapes.Rectangle:
                    _iGeometricShape = new Rectangle(EGeometricShapes.Rectangle, side1, side2);
                    break;

                case EGeometricShapes.Trapeze:
                    _iGeometricShape = new Trapeze(EGeometricShapes.Trapeze, side1, side2, base1, base2, height);
                    break;

                default:
                    throw new Exception("Unsupported Geometric Form.");
            }

            return _iGeometricShape;
        }
    }
}