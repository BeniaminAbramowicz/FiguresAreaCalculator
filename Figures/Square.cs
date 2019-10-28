using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Figures
{
    public class Square: Figure
    {
        public double getArea()
        {
            return (sideA * sideA);
        }
    }
}