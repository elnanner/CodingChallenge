using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Contracts;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var formas = new List<FormaGeometrica> { 
                new FormaGeometrica(EGeometricShapes.Square, 5, null, null, null, null), 
                new FormaGeometrica(EGeometricShapes.Square, 5, null, null, null, null), 
                new FormaGeometrica(EGeometricShapes.Rectangle, 8, 4, null, null, null), 
                new FormaGeometrica(EGeometricShapes.EquilateralTriangle, 8, null, null, null, null), 
                new FormaGeometrica(EGeometricShapes.Trapeze, 8, 4, 2, 1, 2), 
                new FormaGeometrica(EGeometricShapes.Trapeze, 8, 4, 2, 1, 2), 
                new FormaGeometrica(EGeometricShapes.Circle,5, null, null, null, null) 
            
            };

            var resumen = FormaGeometrica.Imprimir(formas, LanguageFactory.GetLanguage(ELanguages.Spanish));
            Console.WriteLine(resumen);
            Console.ReadKey();
        }
    }
}
