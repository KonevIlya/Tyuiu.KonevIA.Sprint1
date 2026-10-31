using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint1.Task3.V16.Lib;
namespace Tyuiu.KonevIA.Sprint1.Task3.V16.Test;
[TestClass]
public class DataServiceTest
{
    [DataTestMethod]
    [DataRow(2.0, 3.0, -5.0)]
    [DataRow(-2.0, 3.0, -1.0)]
    [DataRow(-2.0, -3.0, 5.0)]
    [DataRow(1.23456, 2.34567, -3.58)]
    public void ValidCoefficient(double x1, double x2, double expected) =>
        Assert.AreEqual(expected, new DataService().CoeffOfQuadraticEquation(x1, x2), 1e-10);
}
