using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01_3DPoint
{
    class Path
    {
        private List<Point3D> pointsPath;

        public List<Point3D> PointsPath
        {
            get { return pointsPath; }
            set { pointsPath = value; }
        } 
    }
}
