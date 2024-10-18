namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 35.565;
            var res = (Math.Truncate(x * 10)) % 10;
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
