using Tyuiu.AidemirAF.Sprint1.Task5.V1.Lib;

namespace Tyuiu.AidemirAF.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x1 = 4;
            double y1 = 6;
            double x2 = 1;
            double y2 = 2;
            DataService ds = new DataService();
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            
            int result = Convert.ToInt32(res);

            int wait = 5;
            Assert.AreEqual(wait, result);
        }
    }
}