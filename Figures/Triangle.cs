using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Figures
{
    public class Triangle: Figure
    {
        public double getArea()
        {
            return (SideA * Height / 2);
        }
    }
}