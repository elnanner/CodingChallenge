using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Entities;
using System;

namespace CodingChallenge.Data.Contracts
{
    public class GeometricShapeFactory
    {
        public static IGeometricShape GetGeometricShape(EGeometricShapes eGeometricShapes) {
            IGeometricShape _iGeometricShape;

            switch (eGeometricShapes)
            {
                case EGeometricShapes.Circle:
                    _iGeometricShape = new Circle();
                    break;

                case EGeometricShapes.EquilateralTriangle:
                    _iGeometricShape = new EquilateralTriangle();
                    break;

                case EGeometricShapes.Square:
                    _iGeometricShape = new Rectangle();
                    break;

                case EGeometricShapes.Trapeze:
                    _iGeometricShape = new Trapeze();
                    break;

                default:
                    throw new Exception("Unsupported Geometric Form.");
            }

            return _iGeometricShape;
        }
    }
}