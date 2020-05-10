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

        #region Constructores
        public FormaGeometrica(EGeometricShapes eGeometricShapes, decimal side1, decimal? side2, decimal? base1, decimal? base2, decimal? height)
        {
            _iGeometricShape = GeometricShapeFactory.GetGeometricShape(eGeometricShapes, side1, side2, base1, base2, height); 

        }
        #endregion

        public static string Imprimir(List<FormaGeometrica> formas, ILanguage idioma)
        {
            Dictionary<IGeometricShape, decimal> _cantShapesAreas = new Dictionary<IGeometricShape, decimal>();

            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(idioma.GetEmpty());
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(idioma.GetTitle());

                foreach (var item in formas)
                {
                    _cantShapesAreas.Add(item._iGeometricShape, item._iGeometricShape.CalculateArea());
                }

                sb.Append(ObtenerLinea(_cantShapesAreas, idioma));

                // FOOTER
                sb.Append(idioma.PrintFooter(_cantShapesAreas));
                
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(Dictionary<IGeometricShape, decimal> cantShapesAreas, ILanguage idioma)
        {
            var sb = new StringBuilder();

            foreach (var shape in cantShapesAreas.GroupBy(x => x.Key.GetTypeE()).Select(x => new GeometricShape { TypeE = x.First().Key.GetTypeE(), Count = x.Count(), Area = x.Sum(a=>a.Key.CalculateArea()), Perimeter = x.Sum(a => a.Key.CalculatePerimeter())/*x.First().Key.CalculatePerimeter()*/}))
            {
                sb.Append(TraducirForma(shape, idioma));
            }

            return sb.ToString();
        }


        private static string TraducirForma(GeometricShape shape, ILanguage idioma)
        {
            return $"{ idioma.PrintCount(shape) + " | " + idioma.PrintArea(shape) + " | " + idioma.PrintPerimeter(shape) }";
        }

    }
}
