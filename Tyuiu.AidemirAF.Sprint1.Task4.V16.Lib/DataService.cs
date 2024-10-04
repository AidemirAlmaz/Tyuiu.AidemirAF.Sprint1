using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AidemirAF.Sprint1.Task4.V16.Lib
{
    public class DataService : ISprint1Task4V16
    {
        public double Calculate(double x)
        {
            double res = Math.Round(1 / (x + 4), 3);
            return res;
        }
    }
}
