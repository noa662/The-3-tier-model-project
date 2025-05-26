using BO;
namespace BlApi;

public interface ISale
{
    int Create(Sale sale);
    Sale Read(int id);
    Sale? Read(Func<Sale, bool> filter);
    List<Sale?> ReadAll(Func<Sale, bool>? filter = null);
    void Update(Sale item);
    void Delete(int id);
}
