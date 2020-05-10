using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Contracts;
using CodingChallenge.Data.Entities;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), new Spanish()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), new English()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new FormaGeometrica(EGeometricShapes.Square, 5, null, null, null, null) };

            var resumen = FormaGeometrica.Imprimir(cuadrados, new Spanish());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area: 25 | Perimetro: 20 <br/><br/>TOTAL:<br/>1 formas Perimetro: 20 Area: 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new FormaGeometrica(EGeometricShapes.Square, 5,null, null, null, null),
                new FormaGeometrica(EGeometricShapes.Square, 1, null, null, null, null),
                new FormaGeometrica(EGeometricShapes.Square, 3, null, null, null, null),
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, new English());

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area: 35 | Perimeter: 36 <br/><br/>TOTAL:<br/>3 shapes Perimeter: 36 Area: 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(EGeometricShapes.Square, 5, null, null, null, null),
                new FormaGeometrica(EGeometricShapes.Circle, 3, null, null, null, null),
                new FormaGeometrica(EGeometricShapes.EquilateralTriangle, 4, null, null, null, null),
                new FormaGeometrica(EGeometricShapes.Square, 2, null, null, null, null),
                new FormaGeometrica(EGeometricShapes.EquilateralTriangle, 9, null, null, null, null),
                new FormaGeometrica(EGeometricShapes.Circle, 2.75m, null, null, null, null),
                new FormaGeometrica(EGeometricShapes.EquilateralTriangle, 4.2m, null, null, null, null)
            };

            var resumen = FormaGeometrica.Imprimir(formas, new English());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area: 29 | Perimeter: 28 <br/>2 Circles | Area: 13,01 | Perimeter: 18,06 <br/>3 Equilateral Triangles | Area: 49,64 | Perimeter: 51,6 <br/><br/>TOTAL:<br/>7 shapes Perimeter: 97,66 Area: 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(EGeometricShapes.Square, 5, null, null, null, null),
                new FormaGeometrica(EGeometricShapes.Circle, 3, null, null, null, null),
                new FormaGeometrica(EGeometricShapes.EquilateralTriangle, 4, null, null, null, null),
                new FormaGeometrica(EGeometricShapes.Square, 2, null, null, null, null),
                new FormaGeometrica(EGeometricShapes.EquilateralTriangle, 9, null, null, null, null),
                new FormaGeometrica(EGeometricShapes.Circle, 2.75m, null, null, null, null),
                new FormaGeometrica(EGeometricShapes.EquilateralTriangle, 4.2m, null, null, null, null)
            };

            var resumen = FormaGeometrica.Imprimir(formas, new Spanish());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area: 29 | Perimetro: 28 <br/>2 Círculos | Area: 13,01 | Perimetro: 18,06 <br/>3 Triángulos Equilateros | Area: 49,64 | Perimetro: 51,6 <br/><br/>TOTAL:<br/>7 formas Perimetro: 97,66 Area: 91,65",
                resumen);
        }
    }
}
