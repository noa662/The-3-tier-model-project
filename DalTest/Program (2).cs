using DalApi;
using DalTest;
using DalList;
using DO;
using Tools;

namespace DalTest;

internal class Program
{
    //static readonly IDal s_dal = new DalList.DalList();
    static readonly IDal s_dal = DalApi.Factory.Get;
    static void Main(string[] args)
    {
        int select = printMainMenu();
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    productMenu();
                    break;
                case 2:
                    saleMenu();
                    break;
                case 3:
                    clientMenu();
                    break;
                case 4:
                    LogManager.ClearLogs();
                    break;
                default:
                    {
                        LogManager.WriteToLog("error in selection", "DalTest", "printMaimMenu");
                        Console.WriteLine("Wrong selection, please select again");
                        break;
                    }
            }
            select = printMainMenu();
        }
    }
    public static void productMenu()
    {
        int selection = printSubMenu("product");
        while (selection != 0)
        {
            switch (selection)
            {
                case 1:
                    try
                    {
                        int id = s_dal.Product.Create(newProduct(0));
                        Console.WriteLine("id: " + id);
                    }
                    catch (DalEntityAlreadyExistsException e)
                    {
                        LogManager.WriteToLog("product exists", "DalTest", "CreateProduct");
                        Console.WriteLine("Item exists " + e.Message);
                    }
                    break;
                case 2:
                    read<Product>(s_dal.Product, "product");
                    break;
                case 3:
                    ReadAll<Product>(s_dal.Product);
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("enter id for update");
                        int id = int.Parse(Console.ReadLine());
                        Product p = newProduct(id);
                        s_dal.Product.Update(p);
                    }
                    catch (DalEntityNotFoundException e)
                    {
                        LogManager.WriteToLog("product does not exists", "DalTest", "UpdateProduct");
                        Console.WriteLine("Id does not exist " + e.Message);
                    }
                    break;
                case 5:
                    Delete<Product>(s_dal.Product, "product");
                    break;
                default:
                    {
                        LogManager.WriteToLog("error in selection", "DalTest", "printMaimMenu");
                        Console.WriteLine("your selection is wrong");
                        break;
                    }
            }
            selection = printSubMenu("product");
        }
    }
    public static void saleMenu()
    {
        int selection = printSubMenu("sale");
        while (selection != 0)
        {
            switch (selection)
            {
                case 1:
                    try
                    {
                        int id = s_dal.Sale.Create(newSale(0));
                        Console.WriteLine("id: " + id);
                    }
                    catch (DalEntityAlreadyExistsException e)
                    {
                        LogManager.WriteToLog("sale exist", "DalTest", "CreateSale");
                        Console.WriteLine("Item exist " + e.Message);
                    }
                    break;
                case 2:
                    read<Sale>(s_dal.Sale, "sale");
                    break;
                case 3:
                    ReadAll<Sale>(s_dal.Sale);
                    break;
                case 4:
                    try
                    {
                        int id;
                        Console.WriteLine("enter id for update");
                        int.TryParse(Console.ReadLine(), out id);
                        Sale s = newSale(id);
                        s_dal.Sale.Update(s);
                    }
                    catch (DalEntityNotFoundException e)
                    {
                        LogManager.WriteToLog("sale is not exist", "DalTest", "UpdateSale");
                        Console.WriteLine("Id does not exists " + e.Message);
                    }
                    break;
                case 5:
                    Delete<Sale>(s_dal.Sale, "sale");
                    break;
                default:
                    {
                        LogManager.WriteToLog("error in selection", "DalTest", "printMaimMenu");
                        Console.WriteLine("your selection is wrong");
                        break;
                    }
            }
            selection = printSubMenu("sale");
        }
    }
    private static void clientMenu()
    {
        int selection = printSubMenu("client");
        while (selection != 0)
        {
            switch (selection)
            {
                case 1:
                    try
                    {
                        int id = s_dal.Client.Create(newClient());
                        Console.WriteLine("id: " + id);
                    }
                    catch (DalEntityAlreadyExistsException e)
                    {
                        LogManager.WriteToLog("client exist", "DalTest", "CreateClient");
                        Console.WriteLine("Item exists " + e.Message);
                    }
                    break;
                case 2:
                    read<Client>(s_dal.Client, "sale");
                    break;
                case 3:
                    ReadAll<Client>(s_dal.Client);
                    break;
                case 4:
                    try
                    {
                        //int id;
                        //Console.WriteLine("enter id for update");
                        //int.TryParse(Console.ReadLine(), out id);
                        Client c = newClient();
                        s_dal.Client.Update(c);
                    }
                    catch (DalEntityNotFoundException e)
                    {
                        LogManager.WriteToLog("client does not exist", "DalTest", "UpdateClient");
                        Console.WriteLine("Id does not exists " + e.Message);
                    }
                    break;
                case 5:
                    Delete<Client>(s_dal.Client, "client");
                    break;
                default:
                    {
                        LogManager.WriteToLog("error in selection", "DalTest", "printMaimMenu");
                        Console.WriteLine("your selection is wrong");
                        break;
                    }
            }
            selection = printSubMenu("customer");
        }
    }
    private static int printMainMenu()
    {
        Console.WriteLine("For product press 1");
        Console.WriteLine("For sale press 2");
        Console.WriteLine("For client press 3");
        Console.WriteLine("For clean Log Folder press 4");
        Console.WriteLine("To exit press 0");
        int select;
        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;
    }
    static int printSubMenu(string item)
    {
        Console.WriteLine($"For create {item} press 1");
        Console.WriteLine($"For read {item} press 2");
        Console.WriteLine($"For read all {item} press 3");
        Console.WriteLine($"For update {item} press 4");
        Console.WriteLine($"For delete {item} press 5");
        Console.WriteLine("To go back press 0");
        int select;
        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;
    }
    static void ReadAll<T>(ICrud<T> crud)
    {
        foreach (var item in crud.ReadAll())
        {
            Console.WriteLine(item + " ");
        }
    }
    private static void read<T>(ICrud<T> crud, string entity)
    {
        Console.WriteLine($"Enter {entity} id");
        try
        {
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(crud.Read(id));
        }
        catch (DalDataAccessException e)
        {
            LogManager.WriteToLog("Id not valid", "DalTest", "Read");
            Console.WriteLine("The id is not valid, please try again" + e.Message);
            read<T>(crud, entity);
        }
    }
    static void Delete<T>(ICrud<T> crud, string entity)
    {
        Console.WriteLine("insert id");
        int id;
        int.TryParse(Console.ReadLine(), out id);
        crud.Delete(id);
        Console.WriteLine("The item deleted!!");
    }
    private static Client newClient()
    {
        try
        {
            Console.WriteLine("Enter id, name, address and phone");
            int Id = int.Parse(Console.ReadLine());
            string Name = Console.ReadLine();
            string Address = Console.ReadLine();
            string Phone = Console.ReadLine();
            return new Client(Id, Name, Address, Phone);
        }
        catch (DalDataAccessException e)
        {
            LogManager.WriteToLog("wrong details", "DalTest", "newClient");
            Console.WriteLine("action field" + e.Message);
            Console.WriteLine("Maybe on of the details was wrong");
            return newClient();
        }
    }
    private static Product newProduct(int id)
    {
        try
        {
            Console.WriteLine("Enter name, category, price and amount");
            string name = Console.ReadLine();
            Category c = newCategory();
            double price = double.Parse(Console.ReadLine());
            int amount = int.Parse(Console.ReadLine());
            return new Product(id, name, price, amount, c);
        }
        catch (DalDataAccessException e)
        {
            LogManager.WriteToLog("wrong details", "DalTest", "newProduct");
            Console.WriteLine("action field" + e.Message);
            Console.WriteLine("Maybe on of the details was wrong");
            return newProduct(id);
        }
    }
    static Category newCategory()
    {
        int selection;
        Console.WriteLine("for LuxuryBeds press 1, CareProducts press 2, Accessories press 3, Food press 4, Clothes press 5");
        if (!int.TryParse(Console.ReadLine(), out selection))
            selection = -1;
        switch (selection)
        {
            case 1:
                return Category.LuxuryBeds;
            case 2:
                return Category.CareProducts;
            case 3:
                return Category.Accessories;
            case 4:
                return Category.Food;
            case 5:
                return Category.Clothes;
            default:
                {
                    LogManager.WriteToLog("invalid selection", "DalTest", "newCategory");
                    Console.WriteLine("invalid input, please try again");
                    return newCategory();
                }
        }
    }
    private static Sale newSale(int id)
    {
        try
        {
            Console.WriteLine("Enter product id, min amount, sale price, is for club, begin date and read date");
            int ProductId = int.Parse(Console.ReadLine());
            int MinAmount = int.Parse(Console.ReadLine());
            double SalePric = double.Parse(Console.ReadLine());
            bool IsForClub = bool.Parse(Console.ReadLine());
            DateTime Begin = DateTime.Parse(Console.ReadLine());
            DateTime End = DateTime.Parse(Console.ReadLine());
            return new Sale(id, ProductId, MinAmount, SalePric, IsForClub, Begin, End);
        }
        catch (DalDataAccessException e)
        {
            LogManager.WriteToLog("wrong details", "DalTest", "newSale");
            Console.WriteLine("action field " + e.Message);
            Console.WriteLine("Maybe on of the details was wrong");
            return newSale(id);
        }
    }
}