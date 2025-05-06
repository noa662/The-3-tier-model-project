namespace DalApi;
public interface IDal
{
    IProduct Product { get; }
    ISale Sale { get; }
    IClient Client { get; }
}
