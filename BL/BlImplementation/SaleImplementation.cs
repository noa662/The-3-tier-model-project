using BlApi;
using BO;
namespace BlImplementation;

internal class SaleImplementation : ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Sale s)
    {
        try
        {
            return _dal.Sale.Create(s.Convert());
        }
        catch
        {
            throw new Exception("");
        }
    }
    public BO.Sale Read(int id)
    {
        try
        {
            return _dal.Sale.Read(id).Convert();
        }
        catch
        {
            throw new Exception("");
        }
    }
    public BO.Sale? Read(Func<BO.Sale, bool> filter)
    {
        try
        {
            return _dal.Sale.ReadAll().Select(c => c.Convert()).FirstOrDefault(filter);
        }
        catch
        {
            throw new Exception("");
        }
    }
    public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
    {
        try
        {
            if (filter == null)
                return _dal.Sale.ReadAll().Select(c => c.Convert()).ToList();
            return _dal.Sale.ReadAll().Select(c => c.Convert()).Where(filter).ToList();
        }
        catch
        {
            throw new Exception("");
        }
    }
    public void Update(BO.Sale item)
    {
        try
        {
            _dal.Sale.Update(item.Convert());
        }
        catch
        {
            throw new Exception("");
        }
    }
    public void Delete(int id)
    {
        try
        {
            _dal.Sale.Delete(id);
        }
        catch
        {
            throw new Exception("");
        }
    }
}
