using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KonevIA.Sprint1.Task1.V17.Lib;

public class DataService : ISprint1Task1V17
{
    public double Calculate(double x, double y) => x * y * (5 - x);
}
