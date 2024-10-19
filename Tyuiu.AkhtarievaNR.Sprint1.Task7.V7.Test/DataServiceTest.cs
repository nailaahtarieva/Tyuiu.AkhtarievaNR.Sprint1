using Tyuiu.AkhtarievaNR.Sprint1.Task7.V7.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint1.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-1.124, res);
        }
    }
}