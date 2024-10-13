using Tyuiu.AkhtarievaNR.Sprint1.Task1.V7.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint1.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3, res);
        }
    }
}