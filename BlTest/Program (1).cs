namespace BlTest
{
    internal class Program
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            BO.Order p = new BO.Order(false);
            s_bl.Sale.Read(323);
        }
    }
}
