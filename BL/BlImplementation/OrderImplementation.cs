using BlApi;
using BO;
namespace BlImplementation;

internal class OrderImplementation : IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public List<BO.SaleInProduct> AddProductToOrder(BO.Order o, int id, int amount)
    {
        try
        {
            BO.Product p = _dal.Product.Read(id).Convert();
            ProductInOrder product = o.productInOrder.FirstOrDefault(x => x.productId == id);
            if (product != null)
            {
                if (p.amount >= product.count + amount)
                    product.count += amount;
                else
                    throw new Exception("אין מספיק במלאי.");
            }
            else
            {
                if (p.amount >= amount)
                {
                    ProductInOrder newP = new ProductInOrder(id, p.name, p.price ?? 0, amount, 0);
                    o.productInOrder.Add(newP);
                    p.amount -= amount;
                }
                else
                    throw new Exception("אין מספיק במלאי.");
            }
            SearchSaleForProduct(product, true);
            CalcTotalPriceForProduct(product);
            CalcTotalPrice(o);
            return product.listSales;
        }
        catch (Exception e)
        {
            throw new Exception("שגיאה בהוספת מוצר להזמנה: " + e.Message);
        }
    }
    public void CalcTotalPriceForProduct(BO.ProductInOrder p)
    {
        int count = p.count;
        double sum = 0;
        List<BO.SaleInProduct> sales = new List<BO.SaleInProduct>();
        foreach (var s in p.listSales)
        {
            if (count < s.count)
                continue;
            int times = count / s.count;
            double price = s.price * times;
            sum += price;
            sales.Add(s);
            if (count == 0)
                break;
        }
        sum += count * (p.basePrice ?? 0);
        p.listSales = sales;
        p.finalPrice = sum;
    }
    public void CalcTotalPrice(BO.Order o)
    {
        o.finalPrice = o.productInOrder.Sum(p => p.finalPrice);
    }
    public void DoOrder(BO.Order o)
    {
        var update = o.productInOrder.Select(p =>
        {
            var x = _dal.Product.Read(p.productId);
            if (x.amount < p.count)
                throw new Exception("אין מספיק מלאי למוצר");
            return x with { amount = x.amount - p.count };
        }).ToList();
        foreach (var x in update)
        {
            _dal.Product.Update(x);
        }
    }
    public void SearchSaleForProduct(BO.ProductInOrder p, bool isExistClient)
    {
        var sales = _dal.Sale.ReadAll(s =>
            s.productId == p.productId &&
            s.dateStartSale <= DateTime.Now &&
            DateTime.Now <= s.dateEndSale &&
            p.count >= s.amountForGetSale);
        if (!isExistClient)
            sales = sales.Where(s => s.onlyClub == false).ToList();
        var sort = sales.OrderBy(s => s.sumPriceInSale).ToList();
        p.listSales = sort.Select(s => s.ConvertToSaleInProduct()).ToList();
    }
}