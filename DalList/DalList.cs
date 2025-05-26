using DalApi;
using DalList;
namespace Dal;
public sealed class DalList : IDal
{
    public static DalList Instance { get; } = new DalList();
    private DalList() { }
    public IProduct Product => new ProductImplementation();
    public ISale Sale => new SaleImplementation();
    public IClient Client => new ClientImplementation();
}
