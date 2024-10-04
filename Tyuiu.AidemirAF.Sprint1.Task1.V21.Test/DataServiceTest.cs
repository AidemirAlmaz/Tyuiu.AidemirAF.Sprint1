using Tyuiu.AidemirAF.Sprint1.Task1.V21.Lib;

namespace Tyuiu.AidemirAF.Sprint1.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}