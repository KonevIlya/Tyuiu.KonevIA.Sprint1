using Tyuiu.KonevIA.Sprint1.Task0.V24.Lib;

namespace Tyuiu.KonevIA.Sprint1.Task0.V24;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #1 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #1");
        Line("Тема: Базовые навыки работы в C#");
        Line("Задание #0");
        Line("Вариант #24");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Вычислить выражение 2*4/4/2+1 и напечатать результат на экране.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        Line("2*4/4/2+1");
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().Calculate());
        Console.ReadLine();
    }
}
