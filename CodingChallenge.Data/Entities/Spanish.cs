using CodingChallenge.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CodingChallenge.Data.Entities
{
    public class Spanish : ILanguage
    {
        public string GetEmpty()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }

        public string GetTitle()
        {
            return "<h1>Reporte de Formas</h1>";
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
                    return  shape.Count + " " + (shape.Count == 1 ? "Círculo" : "Círculos");
                case Classes.EGeometricShapes.EquilateralTriangle:
                    return  shape.Count + " " + (shape.Count == 1 ? "Triangulo Equilatero" : "Triángulos Equilateros");
                case Classes.EGeometricShapes.Square:
                    return  shape.Count + " " + (shape.Count == 1 ? "Cuadrado" : "Cuadrados");
                case Classes.EGeometricShapes.Trapeze:
                    return  shape.Count + " " + (shape.Count == 1 ? "Trapezoide" : "Trapezoides");
                case Classes.EGeometricShapes.Rectangle:
                    return  shape.Count + " " + (shape.Count == 1 ? "Rectangulo" : "Rectangulos");
                    
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
            return $"Perimetro: {shape.Perimeter:#.##} <br/>";
        }

        public string PrintFooter(IDictionary<IGeometricShape, decimal> shapes)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<br/>TOTAL:<br/>");
            sb.Append($"{shapes.Count} formas ");
            sb.Append($"Perimetro: {shapes.Sum(x=>x.Key.CalculatePerimeter()):#.##} ");
            sb.Append($"Area: {shapes.Sum(x=>x.Key.CalculateArea()):#.##}");

            return sb.ToString();
        }
    }
}