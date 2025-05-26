namespace BO;
public class ProductInOrder
{
    public int productId { get; init; }
    public string? productName { get; init; }
    public double? basePrice { get; set; }
    public int count { get; set; }
    public List<SaleInProduct> listSales { get; set; }
    public double finalPrice { get; set; }

    public ProductInOrder()
    {
        productId = 0;
        productName = null;
        basePrice = 0;
        count = 0;
        listSales = new List<SaleInProduct>();
        finalPrice = 0;
    }
    public ProductInOrder(int productId, string productName, double basePrice, int count, double finalPrice)
    {
        this.productId = productId;
        this.productName = productName;
        this.basePrice = basePrice;
        this.count = count;
        this.listSales = new List<SaleInProduct>();
        this.finalPrice = finalPrice;
    }
}
