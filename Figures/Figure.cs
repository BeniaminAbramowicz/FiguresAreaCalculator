using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Figures
{
    public class Figure
    {
        private double _sideA;
        public double SideA { get => _sideA; set => _sideA = value; }

        private double _sideB;
        public double SideB { get => _sideB; set => _sideB = value; }

        private double _height;
        public double Height { get => _height; set => _height = value; }

        private double _radius;
        public double Radius { get => _radius; set => _radius = value; }
    }
}