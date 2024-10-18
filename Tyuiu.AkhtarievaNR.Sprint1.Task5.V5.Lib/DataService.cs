using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AkhtarievaNR.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            //var res = (Math.Truncate(x * 10)) % 10;
            x = (x * 10) % 10;
            int res = Convert.ToInt32(Math.Truncate(x));
            return res;
        }
    }
}
