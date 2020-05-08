using CodingChallenge.Data.Entities;

namespace CodingChallenge.Data.Contracts
{
    public interface ILanguage
    {
        string Print();
        string GetEmpty();
        string GetTitle();
        string GetCount(GeometricShape shape);
    }
}
