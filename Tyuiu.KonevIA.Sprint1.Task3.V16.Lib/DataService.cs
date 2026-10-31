using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KonevIA.Sprint1.Task3.V16.Lib;

public class DataService : ISprint1Task3V16
{
    public double CoeffOfQuadraticEquation(double x1, double x2) => Math.Round(-x1 - x2, 3);
}

