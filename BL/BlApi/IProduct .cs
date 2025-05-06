using BO;
namespace BlApi;

public interface IProduct
{
    int Create(Product product);
    Product Read(int id);
    Product? Read(Func<Product, bool> filter);
    List<Product?> ReadAll(Func<Product, bool>? filter = null);
    void Update(Product item);
    void Delete(int id);
    List<Product> getListSales(int id, bool favorite);
}
