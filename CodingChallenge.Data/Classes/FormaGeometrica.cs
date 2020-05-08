/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using CodingChallenge.Data.Contracts;
using CodingChallenge.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        #region Formas
        private IGeometricShape _iGeometricShape;
        #endregion

        #region Idiomas
        private ILanguage _iLanguage;
        #endregion

        public FormaGeometrica(EGeometricShapes eGeometricShapes, decimal ancho)
        {
            _iGeometricShape = GeometricShapeFactory.GetGeometricShape(eGeometricShapes);

            _iGeometricShape.SetSide(ancho);
        }
        public static string Imprimir(List<FormaGeometrica> formas, ILanguage idioma)
        {
            Dictionary<IGeometricShape, decimal> _cantShapesAreas = new Dictionary<IGeometricShape, decimal>();
            Dictionary<IGeometricShape, decimal> _cantShapesPerimeters = new Dictionary<IGeometricShape, decimal>();

            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(idioma.GetEmpty());
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                // Hay por lo menos una forma
                // HEADER
                sb.Append(idioma.GetTitle());

                foreach (var item in formas)
                {
                    _cantShapesAreas.Add(item._iGeometricShape, item._iGeometricShape.CalculateArea());
                    //_cantShapesPerimeters.Add(item._iGeometricShape, item._iGeometricShape.CalculatePerimeter());
                }

                sb.Append(ObtenerLinea(_cantShapesAreas, _cantShapesPerimeters, idioma));

                // FOOTER
                //sb.Append("TOTAL:<br/>");
                //sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + (idioma == Castellano ? "formas" : "shapes") + " ");
                //sb.Append((idioma == Castellano ? "Perimetro " : "Perimeter ") + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos).ToString("#.##") + " ");
                //sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos).ToString("#.##"));
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(Dictionary<IGeometricShape, decimal> cantShapesAreas,
           Dictionary<IGeometricShape, decimal> cantShapesPerimeters,
           ILanguage idioma)
        {
            var sb = new StringBuilder();

            foreach (var shape in cantShapesAreas.GroupBy(x => x.Key.GetTypeE()).Select(x => new GeometricShape() { Type = "", Count = x.Count() }))
            {
                sb.AppendLine(TraducirForma(shape, idioma));
            }

            return "";
            //return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
        }


        private static string TraducirForma(GeometricShape shape, ILanguage idioma)
        {
            return idioma.GetCount(shape);
        }

        public decimal CalcularArea()
        {
            //switch (Tipo)
            //{
            //    case Cuadrado: return _lado * _lado;
            //    case Circulo: return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
            //    case TrianguloEquilatero: return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
            //    default:
            throw new ArgumentOutOfRangeException(@"Forma desconocida");
            //}
        }

        public decimal CalcularPerimetro()
        {
            //switch (Tipo)
            //{
            //    case Cuadrado: return _lado * 4;
            //    case Circulo: return (decimal)Math.PI * _lado;
            //    case TrianguloEquilatero: return _lado * 3;
            //    default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            //}
        }
    }
}
