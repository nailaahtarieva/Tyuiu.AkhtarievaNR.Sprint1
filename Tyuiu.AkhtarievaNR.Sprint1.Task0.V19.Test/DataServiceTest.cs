using Tyuiu.AkhtarievaNR.Sprint1.Task0.V19.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint1.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(10, res);
        }
    }
}