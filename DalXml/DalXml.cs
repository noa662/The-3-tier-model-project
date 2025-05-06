using DalApi;

namespace Dal;
internal sealed class DalXml : IDal
{
    private static readonly DalXml instance = new DalXml();
    public static DalXml Instance
    {
        get
        {
            return instance;
        }
    }
    private DalXml() { }
    IProduct IDal.Product => new productImplementation();
    ISale IDal.Sale => new saleImplementation();
    IClient IDal.Client => new clientImplementation();
}
