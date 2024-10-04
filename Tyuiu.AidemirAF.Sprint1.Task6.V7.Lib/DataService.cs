using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AidemirAF.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            string res = value.Substring(0, value.Length - 1);
            return res;
        }
    }
}
