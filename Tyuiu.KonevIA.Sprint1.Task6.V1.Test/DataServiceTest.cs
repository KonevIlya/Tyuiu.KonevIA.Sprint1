using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint1.Task6.V1.Lib;

namespace Tyuiu.KonevIA.Sprint1.Task6.V1.Test;

[TestClass]
public class DataServiceTest
{
    [DataTestMethod]
    [DataRow("1", "49")]
    [DataRow("A", "65")]
    [DataRow("я", "1103")]
    [DataRow(" ", "32")]
    [DataRow(".", "46")]
    public void ValidSymbolCode(string value, string expected) =>
        Assert.AreEqual(expected, new DataService().SymbolCode(value));
}
