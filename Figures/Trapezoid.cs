using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Figures
{
    public class Trapezoid: Figure
    {
        public double getArea()
        {
            return ((SideA + SideB) * Height) / 2;
        }
    }
}