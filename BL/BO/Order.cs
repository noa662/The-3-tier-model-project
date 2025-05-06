namespace BO;

public class Order
{
    public bool? favorite { get; set; }
    public List<ProductInOrder> productInOrder { get; set; }
    public double finalPrice { get; set; }

    public Order()
    {
        favorite = false;
        productInOrder = new List<ProductInOrder>();
        finalPrice = 0;
    }

    public Order(bool favorite)
    {
        this.favorite = favorite;
        this.productInOrder = new List<ProductInOrder>();
        this.finalPrice = 0;
    }
    public string ToString() => $"favorite: {favorite} finalPrice: {finalPrice}";
}
