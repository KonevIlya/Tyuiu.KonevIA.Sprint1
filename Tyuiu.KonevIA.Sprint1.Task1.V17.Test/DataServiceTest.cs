using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint1.Task1.V17.Lib;

namespace Tyuiu.KonevIA.Sprint1.Task1.V17.Test;

[TestClass]
public class DataServiceTest
{
    [DataTestMethod]
    [DataRow(2.0, 3.0, 18.0)]
    [DataRow(5.0, 7.0, 0.0)]
    [DataRow(-2.0, 3.0, -42.0)]
    [DataRow(1.5, 2.0, 10.5)]
    public void ValidExpression(double x, double y, double expected) =>
        Assert.AreEqual(expected, new DataService().Calculate(x, y), 1e-10);
}
