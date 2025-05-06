using BlApi;
namespace BlImplementation;

internal class Bl :IBl
{
    public IClient Client => new ClientImplementation();
    public IProduct Product => new ProductImplementation();
    public ISale Sale => new SaleImplementation();
    public IOrder Order => new OrderImplementation();
}
