using Tyuiu.AkhtarievaNR.Sprint1.Task5.V5.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExspression()
        {
            DataService ds = new DataService();
            double x = 32.597;
            var res = ds.Calculate(x);
            Assert.AreEqual(5, res);
        }
    }
}