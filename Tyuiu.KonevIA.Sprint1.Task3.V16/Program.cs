using Tyuiu.KonevIA.Sprint1.Task3.V16.Lib;

namespace Tyuiu.KonevIA.Sprint1.Task3.V16;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #1 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #1");
        Line("Тема: Операторы составного присваивания");
        Line("Задание #3");
        Line("Вариант #16");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Вычислить b = -x1-x2. Округлить до трёх знаков после запятой.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        Console.Write("Введите x1: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите x2: ");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().CoeffOfQuadraticEquation(x, y));
        Console.ReadLine();
    }
}


