using System;

namespace WebApplication1.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }
        public double GetArea()
        {
            return (Radius * Radius * Math.PI);
        }
    }
}