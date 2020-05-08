using CodingChallenge.Data.Contracts;
using System;

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
        public string GetCount(GeometricShape shape)
        {
            switch (shape.TypeE)
            {
                case Classes.EGeometricShapes.Circle:
                    return "Cantidad: " + shape.Count + " " + (shape.Count == 1 ? "Circulo" : "Circulos");
                case Classes.EGeometricShapes.EquilateralTriangle:
                    return "Cantidad: " + shape.Count + " " + (shape.Count == 1 ? "Triangulo Equilatero" : "Triangulos Equilateros");
                case Classes.EGeometricShapes.Square:
                    return "Cantidad: " + shape.Count + " " + (shape.Count == 1 ? "Cuadrad" : "Cuadrados");
                case Classes.EGeometricShapes.Trapeze:
                    return "Cantidad: " + shape.Count + " " + (shape.Count == 1 ? "Trapezoide" : "Trapezoides");
                default:
                    return "";
            }
        }
    }
}