using FormasGeometricas.Entities.Enums;
using System;

namespace FormasGeometricas.Entities
{
    abstract class Forma
    {
        public Color color{get; set;}

        public Forma(Color color)
        {
            Color = color;
        }

        public abstract double Area()
        {

        }
    }
}




