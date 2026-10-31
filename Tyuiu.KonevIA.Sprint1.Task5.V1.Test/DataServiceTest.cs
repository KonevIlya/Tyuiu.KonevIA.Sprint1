using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.KonevIA.Sprint1.Task5.V1.Test;

[TestClass]
public class DataServiceTest
{
    [DataTestMethod]
    [DataRow(0.0, 0.0, 3.0, 4.0, 5)]
    [DataRow(-1.0, -2.0, -1.0, -2.0, 0)]
    [DataRow(3.0, 4.0, 0.0, 0.0, 5)]
    [DataRow(0.0, 0.0, 1.0, 1.0, 1)]
    [DataRow(0.0, 0.0, 2.0, 2.0, 3)]
    [DataRow(0.0, 0.0, 2.5, 0.0, 2)]
    [DataRow(0.0, 0.0, 3.5, 0.0, 4)]
    public void ValidDistance(double x1, double y1, double x2, double y2, int expected) =>
        Assert.AreEqual(expected, new DataService().DistanceBetweenDots(x1, y1, x2, y2));
}
