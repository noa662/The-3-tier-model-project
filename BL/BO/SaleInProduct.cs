namespace BO;

public class SaleInProduct
{
    public int SaleId { get; init; }
    public int count { get; set; }
    public double price { get; set; }
    public bool allClients { get; set; }

    public SaleInProduct()
    {
        SaleId = 0;
        count = 0;
        price = 0;
        allClients = false;
    }

    public SaleInProduct(int SaleId, int count, double price, bool allClients)
    {
        this.SaleId = SaleId;
        this.count = count;
        this.price = price;
        this.allClients = allClients;
    }
}
