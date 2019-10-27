using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Figures
{
    public class Square: Figure
    {
        public int getArea()
        {
            return (sideA * sideA);
        }
    }
}