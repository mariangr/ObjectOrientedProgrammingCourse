using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PathStorage
{
    public static List<Point3D> LoadPath(string filePath)
    {
        List<Point3D> path3D = new List<Point3D>();

        using (StreamReader path3DFile = new StreamReader(filePath))
        {
            string currentLine = path3DFile.ReadLine();

            while (currentLine != null)
            {
                Point3D currentPoint = new Point3D(int.Parse(currentLine[0].ToString()), int.Parse(currentLine[1].ToString()), int.Parse(currentLine[2].ToString()));
                path3D.Add(currentPoint);
                currentLine = path3DFile.ReadLine();
            }
        }

        return path3D;
    }

    public static void SavePath(List<Point3D> path3D)
    {
        StringBuilder result = new StringBuilder();

        foreach (var item in path3D)
        {
            result.AppendLine(item.XCoord.ToString() + item.YCoord + item.ZCoord);
        }

        File.WriteAllText("pathStorage.txt", result.ToString());
    }
}

