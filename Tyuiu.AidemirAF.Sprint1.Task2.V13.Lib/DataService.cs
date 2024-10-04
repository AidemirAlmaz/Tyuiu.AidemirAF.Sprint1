using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AidemirAF.Sprint1.Task2.V13.Lib
{
    public class DataService : ISprint1Task2V13
    {
        public double ConvertMilesToKm(int value)
        {
            double res = Math.Round(value * 1.61, 3);
            return res;
        }
    }
}
