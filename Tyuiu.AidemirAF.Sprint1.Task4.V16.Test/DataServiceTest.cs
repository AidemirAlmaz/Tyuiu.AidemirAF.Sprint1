using Tyuiu.AidemirAF.Sprint1.Task4.V16.Lib;

namespace Tyuiu.AidemirAF.Sprint1.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 0.25;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}