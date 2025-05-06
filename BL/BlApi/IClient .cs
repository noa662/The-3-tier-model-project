using BO;
namespace BlApi;

public interface IClient
{
    int Create(Client client);
    Client Read(int id);
    Client? Read(Func<Client, bool> filter);
    List<Client?> ReadAll(Func<Client, bool>? filter = null);
    void Update(Client item);
    void Delete(int id);
    bool IsExist(Client client);
}
