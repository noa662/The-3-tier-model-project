using DO;
using DalApi;
using Tools;
namespace DalList;
internal record ProductImplementation : IProduct
{
    public int Create(Product item)
    {
        LogManager.WriteToLog("start create product", "DalList", "Create");
        if (DataSource.Products.Any(p => p.id == item.id))
        {
            LogManager.WriteToLog("error create product", "DalList", "Create");
            throw new DalEntityAlreadyExistsException("Product already exists");
        }
        Product p = item with { id = DataSource.Config.ProductId };
        DataSource.Products.Add(p);
        LogManager.WriteToLog("end create product", "DalList", "Create");
        return p.id;
    }
    public void Delete(int id)
    {
        LogManager.WriteToLog("start delete product", "DalList", "Delete");
        var product = DataSource.Products.FirstOrDefault(p => p.id == id);
        if (product == null)
        {
            LogManager.WriteToLog("error delete product", "DalList", "Delete");
            throw new DalEntityNotFoundException("Product not exists");
        }
        string nameProduct=product.name??"";
        DataSource.Products.Remove(product);
        Console.WriteLine($"The product: {nameProduct} deleted");
        LogManager.WriteToLog("end delete product", "DalList", "Delete");
    }
    public Product Read(int id)
    {
        LogManager.WriteToLog("start read product", "DalList", "Read");
        var product = DataSource.Products.FirstOrDefault(p => p.id == id);
        if (product == null)
        {
            LogManager.WriteToLog("error read product", "DalList", "Read");
            throw new DalEntityNotFoundException("Product not exists");
        }
        LogManager.WriteToLog("end read product", "DalList", "Read");
        return product;
    }
    public Product? Read(Func<Product, bool> filter)
    {
        LogManager.WriteToLog("start read product by filter", "DalList", "Read");
        var product = DataSource.Products.FirstOrDefault(filter);
        if (product == null)
        {
            LogManager.WriteToLog("error read product by filter", "DalList", "Read");
            throw new DalEntityNotFoundException("Product not found with the given filter");
        }
        LogManager.WriteToLog("end read product by filter", "DalList", "Read");
        return product;
    }
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.WriteToLog("read all products", "DalList", "ReadAll");
        if (filter == null)
            return DataSource.Products.ToList();
        return DataSource.Products.Where(filter).ToList();
    }
    //public List<Product> ReadAll()
    //{
    //    LogManager.WriteToLog("read all products", "DalList", "ReadAll");
    //    return new List<Product>(DataSource.Products);
    //}
    public void Update(Product item)
    {
        LogManager.WriteToLog("start update product", "DalList", "Update");
        var index = DataSource.Products.FindIndex(p => p.name == item.name);
        if (index == -1)
        {
            LogManager.WriteToLog("error update product", "DalList", "Update");
            throw new DalEntityNotFoundException("Product not exists");
        }
        DataSource.Products[index] = item;
        LogManager.WriteToLog("end update product", "DalList", "Update");
    }
}