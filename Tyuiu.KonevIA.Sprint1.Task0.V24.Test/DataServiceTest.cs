using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint1.Task0.V24.Lib;

namespace Tyuiu.KonevIA.Sprint1.Task0.V24.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression() => Assert.AreEqual(2.0, new DataService().Calculate());
}
