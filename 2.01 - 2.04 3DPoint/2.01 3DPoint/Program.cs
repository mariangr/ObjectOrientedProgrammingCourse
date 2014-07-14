using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

public struct Point3D
{
    public Point3D(int x, int y, int z) : this()
    {
        this.XCoord=x;
        this.YCoord=y;
        this.ZCoord=z;
    }

    public int XCoord { set; get; }
    public int YCoord { set; get; }
    public int ZCoord { set; get; }

    private static readonly Point3D startCoord = new Point3D(0, 0, 0);
    public static Point3D StartPoint { get; private set; }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine("X: " + this.XCoord);
        result.AppendLine("Y: " + this.YCoord);
        result.AppendLine("Z: " + this.ZCoord);
        return result.ToString();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point3D point = new Point3D();

        point.XCoord = 1;
        point.YCoord = 1;
        point.ZCoord = 1;

        Console.WriteLine(point.ToString());

        Point3D zeroPoint = Point3D.StartPoint;

        Console.WriteLine(zeroPoint);

        Console.WriteLine(CalculateDistanceClass.CalculateTheDistance(point, zeroPoint));

        List<Point3D> path3DToSave = new List<Point3D>();
        path3DToSave.Add(Point3D.StartPoint);
        path3DToSave.Add(point);

        PathStorage.SavePath(path3DToSave);

        List<Point3D> path3DToLoad = new List<Point3D>();
        path3DToLoad = PathStorage.LoadPath("pathStorage.txt");

        Console.WriteLine();
        

    }
}

