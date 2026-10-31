using Tyuiu.KonevIA.Sprint1.Task1.V17.Lib;

namespace Tyuiu.KonevIA.Sprint1.Task1.V17;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #1 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #1");
        Line("Тема: Организация ввода/вывода в консольных приложениях");
        Line("Задание #1");
        Line("Вариант #17");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Ввести x и y, вычислить x*y*(5-x) и напечатать результат.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        Console.Write("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().Calculate(x, y));
        Console.ReadLine();
    }
}

