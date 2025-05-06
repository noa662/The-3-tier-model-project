namespace BlApi;

public interface IBl
{
    IClient Client { get; }
    IOrder Order { get; }
    IProduct Product { get; }
    ISale Sale { get; }
}
