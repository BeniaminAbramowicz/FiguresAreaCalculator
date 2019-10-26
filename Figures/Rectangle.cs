using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WebApplication1.Figures.Figure;

namespace WebApplication1.Figures
{
    public class Rectangle: Figure
    {
        public int GetArea()
        {
            return (sideA * sideB);
        }
    }
}