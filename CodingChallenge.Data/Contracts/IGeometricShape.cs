using CodingChallenge.Data.Classes;

namespace CodingChallenge.Data.Contracts
{
    public interface IGeometricShape
    {
        decimal CalculateArea();
        decimal CalculatePerimeter();
        void SetSide(decimal side);
        decimal GetArea();
        decimal GetPerimeter();
        EGeometricShapes GetTypeE();
    }
}