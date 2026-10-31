using Tyuiu.KonevIA.Sprint1.Task4.V19.Lib;

namespace Tyuiu.KonevIA.Sprint1.Task4.V19;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #1 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #1");
        Line("Тема: Class Math");
        Line("Задание #4");
        Line("Вариант #19");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Вычислить (x+y)/|x-2|. Округлить до трёх знаков после запятой.");
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


