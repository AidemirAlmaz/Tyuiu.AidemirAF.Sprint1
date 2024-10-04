using Tyuiu.AidemirAF.Sprint1.Task2.V13.Lib;

namespace Tyuiu.AidemirAF.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.ConvertMilesToKm(x);
            Assert.AreEqual(1.61, res);
        }
    }
}