using Tyuiu.KonevIA.Sprint1.Task7.V23.Lib;

namespace Tyuiu.KonevIA.Sprint1.Task7.V23;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #1 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #1");
        Line("Тема: Итоговые проекты по спринту");
        Line("Задание #7");
        Line("Вариант #23");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("z = x - 10^sin(x) + 20*x^2/(3*x^3) + cos(x^2 - y).");
        Line("Ответ округлить до трёх знаков после запятой.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ (x != 0):");
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




