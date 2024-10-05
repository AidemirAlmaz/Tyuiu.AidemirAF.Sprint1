using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AidemirAF.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            string[] words = value.Split(' ');
            value = words[0].Remove(words[0].Length - 1) + " " + words[1].Remove(words[1].Length - 1);
            return value;
        } 
    }
}
