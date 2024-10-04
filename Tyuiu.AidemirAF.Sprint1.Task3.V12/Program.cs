using Tyuiu.AidemirAF.Sprint1.Task3.V12.Lib;

//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчеты и печатает результат на экране.
//Расчеты: Напишите программу вычисления площади прямоугольного треугольника по длинам двух катетов.

namespace Tyuiu.AidemirAF.Sprint1.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            double x;
            double y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine("Площадь прямоугольного треугольника = " + ds.TriangleArea(x, y));
            Console.ReadLine();

        }
    }
}
