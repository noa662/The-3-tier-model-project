namespace DO;

public record Product(int id, string? name = null, double? price = 0, int? amount = 0, Category category=0)
{
    public Product() : this( 0,null, 0, 0, new Category())
    {
    }
}
