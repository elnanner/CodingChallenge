using CodingChallenge.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public string PrintCount(GeometricShape shape)
        {
            switch (shape.TypeE)
            {
                case Classes.EGeometricShapes.Circle:
                    return shape.Count + " " + (shape.Count == 1 ? "Circle" : "Circles");
                case Classes.EGeometricShapes.EquilateralTriangle:
                    return shape.Count + " " + (shape.Count == 1 ? "Equilateral triangle" : "Equilateral Triangles");
                case Classes.EGeometricShapes.Square:
                    return shape.Count + " " + (shape.Count == 1 ? "Square" : "Squares");
                case Classes.EGeometricShapes.Trapeze:
                    return shape.Count + " " + (shape.Count == 1 ? "Trapeze" : "Trapezoids");
                case Classes.EGeometricShapes.Rectangle:
                    return shape.Count + " " + (shape.Count == 1 ? "Rectangle" : "Rectangles");
                default:
                    return "";
            }
        }

        public string PrintArea(GeometricShape shape)
        {
            return $"Area: {shape.Area:#.##}";
        }

        public string PrintPerimeter(GeometricShape shape)
        {
            return $"Perimeter: {shape.Perimeter:#.##} <br/>";
        }

        public string PrintFooter(IDictionary<IGeometricShape, decimal> shapes)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<br/>TOTAL:<br/>");
            sb.Append($"{shapes.Count} shapes ");
            sb.Append($"Perimeter: {shapes.Sum(x => x.Key.CalculatePerimeter()):#.##} ");
            sb.Append($"Area: {shapes.Sum(x => x.Key.CalculateArea()):#.##}");

            return sb.ToString();
        }
    }
}