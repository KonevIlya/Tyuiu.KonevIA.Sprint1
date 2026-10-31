using Tyuiu.KonevIA.Sprint1.Task2.V3.Lib;

namespace Tyuiu.KonevIA.Sprint1.Task2.V3;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #1 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #1");
        Line("Тема: Арифметические операторы в C#");
        Line("Задание #2");
        Line("Вариант #3");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Перевести целое количество часов в минуты.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        Console.Write("Введите количество часов: ");
        int hour = Convert.ToInt32(Console.ReadLine());
        
        
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().ConvertHourToMin(hour));
        Console.ReadLine();
    }
}


