using CodingChallenge.Data.Classes;
using System;

namespace CodingChallenge.Data.Entities
{
    public class GeometricShape
    {
        internal decimal Side;// { get; set; }// en algunas clases concretas representa el lado 1

        internal string Type;

        internal decimal Count;

        internal EGeometricShapes TypeE;

        internal decimal Area;

        internal decimal Perimeter;
    }
}