using DO;
using System.Reflection;
using System.Text;
namespace BO;

internal static class Tools
{
    public static DO.Client Convert(this BO.Client c)
    {
        return new DO.Client(c.id, c.name, c.address, c.phone);
    }
    public static DO.Product Convert(this BO.Product c)
    {
        return new DO.Product(c.id, c.name, c.price, c.amount, (DO.Category)(c.category));
    }
    public static DO.Sale Convert(this BO.Sale c)
    {
        return new DO.Sale(c.id, c.productId, c.amountForGetSale, c.sumPriceInSale, c.onlyClub, c.dateStartSale, c.dateEndSale);
    }
    public static BO.Client Convert(this DO.Client c)
    {
        return new BO.Client(c.id, c.name, c.adress, c.phone);
    }
    public static BO.Product Convert(this DO.Product c)
    {
        return new BO.Product( c.name, c.price, c.amount, (BO.Category)(c.category));
    }
    public static BO.Sale Convert(this DO.Sale c)
    {
        return new BO.Sale(c.id, c.productId, c.amountForGetSale, c.sumPriceInSale, c.onlyClub, c.dateStartSale, c.dateEndSale);
    }
    public static BO.SaleInProduct ConvertToSaleInProduct(this DO.Sale s)
    {
        return new BO.SaleInProduct(s.id, s.amountForGetSale, s.sumPriceInSale, !s.onlyClub.GetValueOrDefault());
    }
    public static string ToStringProperty<T>(this T obj, string prefix = "")
    {
        StringBuilder sb = new StringBuilder();
        Type type = obj.GetType();
        foreach (PropertyInfo prop in type.GetProperties())
        {
            sb.AppendLine($"{prefix}{prop.Name}= {prop.GetValue(obj)}");
        }
        return sb.ToString();
    }
}
