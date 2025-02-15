using System.Collections;
using System.Drawing;

int[] myArrayOfInts = { 1, 2, 3, 4, 5 };
List<int> myGenericList = new List<int> { 1, 2, 3, 4, 5 };
ArrayList myArrayList = new ArrayList { 1, 2, 3, 4, 5 };

List<Point> myPointList = new List<Point> { new Point(1, 2), new Point(3, 4) };
foreach (Point p in myPointList)
{
    Console.WriteLine(p);
}