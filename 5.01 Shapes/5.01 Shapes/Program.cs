using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._01_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Rectangle(5, 6), new Triangle(6, 5), new Circle(5) };

            foreach (var item in shapes)
            {
                Console.WriteLine(item.GetType().Name + " " + item.CalculateSurface());
            }
        }
    }
}
