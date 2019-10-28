using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Figures
{
    public class Circle:Figure
    {
        public double getArea()
        {
            return (radius * radius * Math.PI);
        }
    }
}