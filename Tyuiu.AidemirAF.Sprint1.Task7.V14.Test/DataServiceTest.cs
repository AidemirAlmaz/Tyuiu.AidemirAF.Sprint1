using Tyuiu.AidemirAF.Sprint1.Task7.V14.Lib;

namespace Tyuiu.AidemirAF.Sprint1.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            double wait = 1.626;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}