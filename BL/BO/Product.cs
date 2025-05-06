namespace BO;

public class Product
{
    public int id { get; init; }
    public string? name { get; init; }
    public double? price { get; init; }
    public int? amount { get; set; }
    public Category category { get; init; }
    public List<SaleInProduct> saleInProduct { get; set; }

    public Product()
    {
        id = 0;
        name = null;
        price = 0;
        amount = 0;
        category = 0;
        saleInProduct = new List<SaleInProduct>();
    }

    public Product( string? name, double? price, int? amount, Category category)
    {
        this.name = name;
        this.price = price;
        this.amount = amount;
        this.category = category;
        this.saleInProduct = new List<SaleInProduct>();
    }
    public string ToString() => $"id: {id} name: {name} price: {price} amount: {amount} catgory: {category}";
}
