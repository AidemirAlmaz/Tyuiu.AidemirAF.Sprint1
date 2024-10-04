using Tyuiu.AidemirAF.Sprint1.Task3.V12.Lib;

namespace Tyuiu.AidemirAF.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 4;
            double wait = 6;
            var res = ds.TriangleArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}