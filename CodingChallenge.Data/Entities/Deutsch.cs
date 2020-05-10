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
                return "Menge: " + shape.Count + " " + (shape.Count == 1 ? "Kreis" : "Kreise");
            case EGeometricShapes.EquilateralTriangle:
                return "Menge: " + shape.Count + " " + (shape.Count == 1 ? "Gleichseitiges Dreieck" : "Gleichseitiges Dreiecke");
            case EGeometricShapes.Square:
                return "Menge: " + shape.Count + " " + (shape.Count == 1 ? "Cuadrad" : "Cuadrados");
            case EGeometricShapes.Trapeze:
                return "Menge: " + shape.Count + " " + (shape.Count == 1 ? "Trapezoide" : "Trapezoides");
            case EGeometricShapes.Rectangle:
                return "Menge: " + shape.Count + " " + (shape.Count == 1 ? "Rechteck" : "Rechteckes");
            default:
                return "";
        }
    }

    public string PrintArea(GeometricShape shape)
    {
        return $"Bereich: {shape.Area:#.##} <br/>";
    }

    public string PrintPerimeter(GeometricShape shape)
    {
        return $"Umfang: {shape.Perimeter:#.##} <br/>";
    }

    public string PrintFooter(IDictionary<IGeometricShape, decimal> shapes )
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("Insgesamt:<br/>");
        sb.Append($" {shapes.Count} shapes ");
        sb.Append($" Umfang: {shapes.Sum(x => x.Key.CalculatePerimeter()):#.##} ");
        sb.Append($" Bereich: {shapes.Sum(x => x.Key.CalculateArea()):#.##} ");

        return sb.ToString();
    }
}