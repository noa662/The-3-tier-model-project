namespace DO;

public record Sale(int id, int? productId = 0, int amountForGetSale = 0,
    double sumPriceInSale = 0, bool? onlyClub = false, DateTime? dateStartSale = null,
    DateTime? dateEndSale = null)
{
    public Sale() : this(0)
    {

    }
}
