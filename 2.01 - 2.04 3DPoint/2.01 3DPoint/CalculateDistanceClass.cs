using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static class CalculateDistanceClass
{
    public static double CalculateTheDistance(Point3D first, Point3D second)
    {
        return Math.Sqrt((first.XCoord - second.XCoord) * (first.XCoord - second.XCoord) + (first.YCoord - second.YCoord) * (first.YCoord - second.YCoord) + (first.ZCoord - second.ZCoord) * (first.ZCoord - second.ZCoord));
    }

}

