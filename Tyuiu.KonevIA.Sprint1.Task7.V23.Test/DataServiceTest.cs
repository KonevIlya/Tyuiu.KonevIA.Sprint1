using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint1.Task7.V23.Lib;

namespace Tyuiu.KonevIA.Sprint1.Task7.V23.Test;

[TestClass]
public class DataServiceTest
{
    [DataTestMethod]
    [DataRow(1.0, 1.0, 1.725)]
    [DataRow(2.0, 4.0, -1.782)]
    [DataRow(-1.0, 1.0, -6.811)]
    [DataRow(3.0, 2.0, 4.592)]
    [DataRow(0.5, -2.0, 10.189)]
    public void ValidExpression(double x, double y, double expected) =>
        Assert.AreEqual(expected, new DataService().Calculate(x, y), 1e-10);
}
