using Tyuiu.AidemirAF.Sprint1.Task7.V14.Lib;

namespace Tyuiu.AidemirAF.Sprint1.Task7.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("*               2                                                                                   *");
            Console.WriteLine("*      -x  5*(x)         2                                                                          *");
            Console.WriteLine("* z = 2  + ------ - cos(x) + sin(2*x*y)                                                             *");
            Console.WriteLine("*               3                                                                                   *");
            Console.WriteLine("*          3*(x)                                                                                    *");

            double x;
            double y;

            Console.WriteLine("Введите число X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
