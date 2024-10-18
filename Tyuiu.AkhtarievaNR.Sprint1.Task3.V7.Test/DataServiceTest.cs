using Tyuiu.AkhtarievaNR.Sprint1.Task3.V7.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 100;        
            var res = ds.VerstsToKilometers(x);
            Assert.AreEqual(106.68, res);
        }
    }
}