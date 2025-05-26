using BlApi;
using BO;
namespace BlImplementation;

internal class ClientImplementation : IClient
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Client c)
    {
        try
        {
            return _dal.Client.Create(c.Convert());
        }
        catch
        {
            throw new BLAlreadyExistsException("this item already exist");
        }
    }
    public BO.Client Read(int id)
    {
        try
        {
            return _dal.Client.Read(id)?.Convert();
        }
        catch
        {
            throw new BLNotFoundException("id is not exist");
        }
    }
    public BO.Client? Read(Func<BO.Client, bool> filter)
    {
        try
        {
            return _dal.Client.ReadAll().Select(c => c.Convert()).FirstOrDefault(filter);
        }
        catch
        {
            throw new BLNotFoundException("items is not exist");
        }
    }

    public List<BO.Client?> ReadAll(Func<BO.Client, bool>? filter = null)
    {
        try
        {
            if (filter == null)
                return _dal.Client.ReadAll().Select(c => c.Convert()).ToList();
            return _dal.Client.ReadAll().Select(c => c.Convert()).Where(filter).ToList();
        }
        catch
        {
            throw new BLNotFoundException("items is not exist");
        }
    }
    public void Update(BO.Client item)
    {
        try
        {
            _dal.Client.Update(item.Convert());
        }
        catch
        {
            throw new BLAccessException("error in update item");
        }
    }
    public void Delete(int id)
    {
        try
        {
            _dal.Client.Delete(id);
        }
        catch
        {
            throw new BLNotFoundException("id is not exist");
        }
    }
    public bool IsExist(BO.Client client)
    {
        try
        {
            if (_dal.Client.Read(client.id).Convert() != null)
                return true;
            return false;
        }
        catch
        {
            throw new BLNotFoundException("item is not exist");
        }
    }
}
