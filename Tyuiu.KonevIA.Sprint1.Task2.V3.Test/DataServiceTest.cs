using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint1.Task2.V3.Lib;
namespace Tyuiu.KonevIA.Sprint1.Task2.V3.Test;
[TestClass]
public class DataServiceTest
{
    [DataTestMethod]
    [DataRow(0, 0)]
    [DataRow(1, 60)]
    [DataRow(2, 120)]
    [DataRow(24, 1440)]
    public void ValidHours(int hour, int expected) =>
        Assert.AreEqual(expected, new DataService().ConvertHourToMin(hour));
}
