using Tyuiu.AidemirAF.Sprint1.Task6.V7.Lib;

namespace Tyuiu.AidemirAF.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strTest = "Hello";
            DataService ds = new DataService();
            string res = ds.DeleteLastLetter( strTest );
            string wait = "Hell";
            Assert.AreEqual(wait, res);
        }
    }
}