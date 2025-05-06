using DO;
using DalApi;
using Tools;
namespace DalList;
internal record SaleImplementation : ISale
{
    public int Create(Sale item)
    {
        LogManager.WriteToLog("start create sale", "DalList", "Create");
        if (DataSource.Sales.Any(s => s.id == item.id))
        {
            LogManager.WriteToLog("error create sale", "DalList", "Create");
            throw new DalEntityAlreadyExistsException("Sale already exists");
        }
        Sale s = item with { id = DataSource.Config.SaleId };
        DataSource.Sales.Add(s);
        LogManager.WriteToLog("end create sale", "DalList", "Create");

        return s.id;
    }
    public void Delete(int id)
    {
        LogManager.WriteToLog("start delete sale", "DalList", "Delete");
        var sale = DataSource.Sales.FirstOrDefault(s => s.id == id);
        if (sale == null)
        {
            LogManager.WriteToLog("error delete sale", "DalList", "Delete");
            throw new DalEntityNotFoundException("Sale not exists");
        }
        DataSource.Sales.Remove(sale);
        LogManager.WriteToLog("end delete sale", "DalList", "Delete");
    }
    public Sale Read(int id)
    {
        LogManager.WriteToLog("start read sale", "DalList", "Read");
        var sale = DataSource.Sales.FirstOrDefault(s => s.id == id);
        if (sale == null)
        {
            LogManager.WriteToLog("error read sale", "DalList", "Read");
            throw new DalEntityNotFoundException("Sale not exists");
        }
        LogManager.WriteToLog("end read sale", "DalList", "Read");
        return sale;
    }
    public Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.WriteToLog("start read sale by filter", "DalList", "Read");

        var sale = DataSource.Sales.FirstOrDefault(filter);
        if (sale == null)
        {
            LogManager.WriteToLog("error read sale by filter", "DalList", "Read");
            throw new DalEntityNotFoundException("Sale not found with the given filter");
        }
        LogManager.WriteToLog("end read sale by filter", "DalList", "Read");
        return sale;
    }
    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.WriteToLog("read all products", "DalList", "ReadAll");
        if (filter == null)
            return DataSource.Sales.ToList();
        return DataSource.Sales.Where(filter).ToList();
    }
    //public List<Sale> ReadAll()
    //{
    //    LogManager.WriteToLog("read all sale", "DalList", "ReadAll");
    //    return new List<Sale>(DataSource.Sales);
    //}
    public void Update(Sale item)
    {
        LogManager.WriteToLog("start update sale", "DalList", "Update");
        var index = DataSource.Sales.FindIndex(s => s.id == item.id);
        if (index == -1)
        {
            LogManager.WriteToLog("error update sale", "DalList", "Update");
            throw new DalEntityNotFoundException("Sale not exists");
        }
        DataSource.Sales[index] = item;
        LogManager.WriteToLog("end update sale", "DalList", "Update");
    }
}
