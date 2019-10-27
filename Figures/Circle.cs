using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Figures
{
    public class Circle:Figure
    {
        public int getArea()
        {
            return (int) (radius * radius * Math.PI);
        }
    }
}