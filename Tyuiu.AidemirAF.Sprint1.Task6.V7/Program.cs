﻿using Tyuiu.AidemirAF.Sprint1.Task6.V7.Lib;

//ЗАДАНИЕ
//Написать программу: пользователь вводит текст.
//Напечатать все слова, удалив из низ последнюю букву.

namespace Tyuiu.AidemirAF.Sprint1.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine(ds.DeleteLastLetter(str));

            Console.ReadKey();
        }
    }
}
