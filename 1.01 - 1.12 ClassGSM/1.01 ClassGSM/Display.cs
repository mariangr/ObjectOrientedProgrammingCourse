using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._01_ClassGSM
{
    class Display
    {
        public Display()
        { 
        }

        public Display(double sizeOfDisplay, ulong numberOfColors)
        {
            this.SizeOfDisplay = sizeOfDisplay;
            this.NumberOfColors = numberOfColors;
        }

        public double SizeOfDisplay {set; get;}
        public ulong NumberOfColors {set; get;}

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Display Size: " + SizeOfDisplay);
            result.AppendLine("Number of colors: " + NumberOfColors);
            return result.ToString();
        }
    }
}
