using DO;
using DalApi;
using DalList;
using static DO.Category;
namespace DalTest;
public class Initialization
{
    private static IDal? s_Dal;

    private static void createClients()
    {
        s_Dal.Client.Create(new Client(1, "לקוח א", "רחוב א'", "050-1234567"));
        s_Dal.Client.Create(new Client(2, "לקוח ב", "רחוב ב'", "050-7654321"));
        s_Dal.Client.Create(new Client(3, "לקוח ג", "רחוב ג'", "052-3456789"));
    }
    private static void createProducts()
    {
        s_Dal.Product.Create(new Product(101, "מוצר 1", 99.99, 50, Category.LuxuryBeds));
        s_Dal.Product.Create(new Product(102, "מוצר 2", 49.99, 20, Category.Clothes));
        s_Dal.Product.Create(new Product(103, "מוצר 3", 19.99, 100, Category.Accessories));
    }
    private static void createSales()
    {
        s_Dal.Sale.Create(new Sale(1001, 101, 12, 199.98, true, DateTime.Now, DateTime.Now.AddDays(7)));
        s_Dal.Sale.Create(new Sale(1002, 102, 2, 49.99, false, DateTime.Now, null));
        s_Dal.Sale.Create(new Sale(1003, 103, 3, 59.97, true, DateTime.Now.AddDays(-1), DateTime.Now.AddDays(6)));
    }
    public static void Initialize(IDal? dal)
    {
        //s_Dal = dal;
        s_Dal = DalApi.Factory.Get;
        //createClients();
        Console.WriteLine("initilize the products? yes/no");
        string ans = Console.ReadLine();
        if (ans == "yes")
        {
            createProducts();
        }
        //createSales();
    }
}