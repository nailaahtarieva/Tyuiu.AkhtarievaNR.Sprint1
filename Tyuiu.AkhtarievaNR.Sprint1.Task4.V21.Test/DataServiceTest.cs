using Tyuiu.AkhtarievaNR.Sprint1.Task4.V21.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint1.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 11;
            double y = 9;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(6.75, res);
        }
    }
}