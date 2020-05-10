using CodingChallenge.Data.Entities;
using System.Collections.Generic;

namespace CodingChallenge.Data.Contracts
{
    public interface ILanguage
    {
        string Print();
        string GetEmpty();
        string GetTitle();
        string PrintCount(GeometricShape shape);
        string PrintArea(GeometricShape shape);
        string PrintPerimeter(GeometricShape shape);
        string PrintFooter(IDictionary<IGeometricShape, decimal> shapes);
    }
}
