using Tyuiu.AkhtarievaNR.Sprint1.Task6.V2.Lib;
namespace Tyuiu.AkhtarievaNR.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Hello, World!";
            DataService ds = new DataService();
            bool res = ds.CheckHello(strTest);
            Assert.AreEqual(true, res);
        }
    }
}