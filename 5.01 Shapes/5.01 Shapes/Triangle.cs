﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._01_Shapes
{
    class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Height)/2;
        }
    }
}
