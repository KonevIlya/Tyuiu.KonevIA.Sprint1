using Tyuiu.KonevIA.Sprint1.Task6.V1.Lib;

namespace Tyuiu.KonevIA.Sprint1.Task6.V1;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #1 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #1");
        Line("Тема: Работа со строками, класс String");
        Line("Задание #6");
        Line("Вариант #1");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Вывести код введённого пользователем символа.");
        Line("Для завершения программы введите точку.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ И РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine("Введите символ и нажмите <Enter>. Для завершения введите точку.");
        var service = new DataService();
        while (true)
        {
            Console.Write("-> ");
            string value = Console.ReadLine();
            if (value == null || value == ".")
                break;
            if (value.Length != 1)
            {
                Console.WriteLine("Введите ровно один символ.");
                continue;
            }
            Console.WriteLine($"Символ: {value} Код: {service.SymbolCode(value)}");
        }
    }
}
