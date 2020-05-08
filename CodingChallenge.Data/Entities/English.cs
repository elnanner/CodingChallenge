using CodingChallenge.Data.Contracts;
using System;

namespace CodingChallenge.Data.Entities
{
    public class English : ILanguage
    {
        public string GetEmpty()
        {
            return "<h1>Empty list of shapes!</h1>";
        }

        public string GetTitle()
        {
            return "<h1>Shapes report</h1>";
        }

        public string Print()
        {
            throw new NotImplementedException();
        }

        public string GetCount(GeometricShape shape)
        {
            switch (shape.TypeE)
            {
                case Classes.EGeometricShapes.Circle:
                    return "Count: " + shape.Count + " " + (shape.Count == 1 ? "Circle" : "Circles");
                case Classes.EGeometricShapes.EquilateralTriangle:
                    return "Count: " + shape.Count + " " + (shape.Count == 1 ? "Equilateral triangle" : "Equilateral triangles");
                case Classes.EGeometricShapes.Square:
                    return "Count: " + shape.Count + " " + (shape.Count == 1 ? "Square" : "Squares");
                case Classes.EGeometricShapes.Trapeze:
                    return "Count: " + shape.Count + " " + (shape.Count == 1 ? "Trapeze" : "Trapezoids");
                default:
                    return "";
            }
        }
    }
}