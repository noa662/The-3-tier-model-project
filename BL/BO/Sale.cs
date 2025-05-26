namespace BO;
public class Sale
{
    public int id { get; init; }
    public int? productId { get; set; }
    public int amountForGetSale { get; set; }
    public double sumPriceInSale { get; set; }
    public bool? onlyClub { get; set; }
    public DateTime? dateStartSale { get; set; }
    public DateTime? dateEndSale { get; set; }
    public Sale()
    {
        productId = null;
        amountForGetSale = 0;
        sumPriceInSale = 0;
        onlyClub = false;
        dateStartSale = null;
        dateEndSale = null;
    }
    public Sale( int? productId, int amountForGetSale, double sumPriceInSale, bool? onlyClub, DateTime? dateStartSale, DateTime? dateEndSale)
    {
        this.productId = productId;
        this.amountForGetSale = amountForGetSale;
        this.sumPriceInSale = sumPriceInSale;
        this.onlyClub = onlyClub;
        this.dateEndSale = dateEndSale;
        this.dateStartSale = dateStartSale;
    }
    public Sale(int id, int? productId, int amountForGetSale, double sumPriceInSale, bool? onlyClub, DateTime? dateStartSale, DateTime? dateEndSale)
    {
        this.id = id;
        this.productId = productId;
        this.amountForGetSale = amountForGetSale;
        this.sumPriceInSale = sumPriceInSale;
        this.onlyClub = onlyClub;
        this.dateEndSale = dateEndSale;
        this.dateStartSale = dateStartSale;
    }
}
