using CodingChallenge.Data.Classes;

namespace CodingChallenge.Data.Contracts
{
    public interface IGeometricShape
    {
        decimal CalculateArea();
        decimal CalculatePerimeter();
        EGeometricShapes GetTypeE();

    }
}