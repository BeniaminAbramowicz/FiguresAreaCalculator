﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Figures
{
    public class Triangle: Figure
    {
        public int getArea()
        {
            return (sideA * height / 2);
        }
    }
}