using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._01_Shapes
{
    class Circle : Shape
    {
        public Circle(double diameter)
        {
            this.Width = diameter;
            this.Height = diameter;
        }

        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow(this.Width / 2, 2);
        }

    }
}
