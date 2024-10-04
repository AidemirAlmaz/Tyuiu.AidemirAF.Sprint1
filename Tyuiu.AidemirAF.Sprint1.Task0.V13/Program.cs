using Tyuiu.AidemirAF.Sprint1.Task0.V13.Lib;

//ЗАДАНИЕ
//Написать программу, которая вычисляет выражение 24/(6*2)-24/6/4 и печатает результат на экране.
namespace Tyuiu.AidemirAF.Sprint1.Task0.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Айдемир А. Ф. | ИИПБ-24-1";
            //Длина строки 75 символов
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                         *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                  *");
            Console.WriteLine("* Задание #0                                                                                        *");
            Console.WriteLine("* Вариант #13                                                                                       *");
            Console.WriteLine("* Выполнил : Айдемир Алмаз Фуатович | ИИПБ-24-1                                                     *");
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                          *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 24/(6*2)-24/6/4                                   *");
            Console.WriteLine("* и печатает результат на экране.                                                                   *");
            Console.WriteLine("*                                                                                                   *");
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* 24/(6*2)-24/6/4                                                                                   *");
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            //Метод Calculate находится в библиотеке Tyuiu.AidemirAF.Sprint1.Task0.V13.Lib
            //в классе DataService
            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }
    }
}
