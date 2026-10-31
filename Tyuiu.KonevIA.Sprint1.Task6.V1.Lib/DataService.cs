using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KonevIA.Sprint1.Task6.V1.Lib;

public class DataService : ISprint1Task6V1
{
    public string SymbolCode(string value) => Convert.ToInt32(Convert.ToChar(value)).ToString();
}
