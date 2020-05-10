using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Contracts;
using CodingChallenge.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Deutsch : ILanguage
{
    public string GetEmpty()
    {
        return "<h1>Leere Liste der Formen!</h1>";
    }

    public string GetTitle()
    {
        return "<h1>Formularbericht</h1>";
    }

    public string Print()
    {
        throw new NotImplementedException();
    }
    public string PrintCount(GeometricShape shape)
    {
        switch (shape.TypeE)
        {
            case EGeometricShapes.Circle:
                return shape.Count + " " + (shape.Count == 1 ? "Kreis" : "Kreise");
            case EGeometricShapes.EquilateralTriangle:
                return shape.Count + " " + (shape.Count == 1 ? "Gleichseitiges Dreieck" : "Gleichseitiges Dreiecke");
            case EGeometricShapes.Square:
                return shape.Count + " " + (shape.Count == 1 ? "Quadrat" : "Quadrate");
            case EGeometricShapes.Trapeze:
                return shape.Count + " " + (shape.Count == 1 ? "Trapezoide" : "Trapezoides");
            case EGeometricShapes.Rectangle:
                return shape.Count + " " + (shape.Count == 1 ? "Rechteck" : "Rechteckes");
            default:
                return "";
        }
    }

    public string PrintArea(GeometricShape shape)
    {
        return $"Bereich: {shape.Area:#.##}";
    }

    public string PrintPerimeter(GeometricShape shape)
    {
        return $"Umfang: {shape.Perimeter:#.##} <br/>";
    }

    public string PrintFooter(IDictionary<IGeometricShape, decimal> shapes )
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("<br/>Insgesamt:<br/>");
        sb.Append($"{shapes.Count} shapes ");
        sb.Append($"Umfang: {shapes.Sum(x => x.Key.CalculatePerimeter()):#.##} ");
        sb.Append($"Bereich: {shapes.Sum(x => x.Key.CalculateArea()):#.##}");

        return sb.ToString();
    }
}