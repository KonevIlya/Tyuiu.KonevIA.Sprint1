using Tyuiu.KonevIA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.KonevIA.Sprint1.Task5.V1;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #1 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #1");
        Line("Тема: Преобразование типов и класс Convert");
        Line("Задание #5");
        Line("Вариант #1");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Найти расстояние между двумя точками (x1, y1) и (x2, y2).");
        Line("Ответ привести к целому с помощью класса Convert.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        Console.Write("Введите x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().DistanceBetweenDots(x1, y1, x2, y2));
        Console.ReadLine();
    }
}




