using Tyuiu.AkhtarievaNR.Sprint1.Task2.V25.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint1.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertRadsToDegrees(x);
            Assert.AreEqual(114.592, res);
        }
    }
}