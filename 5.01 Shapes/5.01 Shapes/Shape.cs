using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._01_Shapes
{
    abstract class Shape
    {
        public abstract double CalculateSurface();

        public double Width { set; get; }
        public double Height { set; get; }


    }
}
