using Tyuiu.AidemirAF.Sprint1.Task5.V1.Lib;

//ЗАДАНИЕ
//Написать программу, которая решает следующую задачу:
//Найти расстояние между двумя точками с заданными координатами (x, y).
//Ответ: целое число

namespace Tyuiu.AidemirAF.Sprint1.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            double x1 = 4;
            double y1 = 6;
            double x2 = 1;
            double y2 = 2;
            Console.WriteLine("Координата точки x1 = " + x1);
            Console.WriteLine("Координата точки y1 = " + y1);
            Console.WriteLine("Координата точки x2 = " + x2);
            Console.WriteLine("Координата точки y2 = " + y2);

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine("Расстояние между двумя точками = " + ds.DistanceBetweenDots(x1, y1, x2, y2));
            Console.ReadLine();
        }
    }
}
