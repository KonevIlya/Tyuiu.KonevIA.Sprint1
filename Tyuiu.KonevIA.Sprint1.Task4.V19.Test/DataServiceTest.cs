using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint1.Task4.V19.Lib;
namespace Tyuiu.KonevIA.Sprint1.Task4.V19.Test;
[TestClass]
public class DataServiceTest
{
    [DataTestMethod]
    [DataRow(4.0, 2.0, 3.0)]
    [DataRow(1.0, 3.0, 4.0)]
    [DataRow(-1.0, -2.0, -1.0)]
    [DataRow(5.0, 2.0, 2.333)]
    [DataRow(0.0, 0.0, 0.0)]
    public void ValidExpression(double x, double y, double expected) =>
        Assert.AreEqual(expected, new DataService().Calculate(x, y), 1e-10);
}
