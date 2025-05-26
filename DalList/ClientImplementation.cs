using DO;
using DalApi;
using Tools;
namespace DalList;

internal class ClientImplementation : IClient
{
    public int Create(Client item)
    {
        LogManager.WriteToLog("start create client", "DalList", "Create");
        if (DataSource.Clients.Any(c => c.id == item.id))
        {
            LogManager.WriteToLog("error create client", "DalList", "Create");
            throw new DalEntityAlreadyExistsException("Customer already exists");
        }
        DataSource.Clients.Add(item);
        LogManager.WriteToLog("end create client", "DalList", "Create");
        return item.id;
    }
    public void Delete(int id)
    {
        LogManager.WriteToLog("start delete client", "DalList", "Delete");
        var client = DataSource.Clients.FirstOrDefault(c => c.id == id);
        if (client == null)
        {
            LogManager.WriteToLog("error delete client", "DalList", "Delete");
            throw new DalEntityNotFoundException("Customer not exists");
        }
        DataSource.Clients.Remove(client);
        LogManager.WriteToLog("end delete client", "DalList", "Delete");
    }
    public Client Read(int id)
    {
        LogManager.WriteToLog("start read client", "DalList", "Read");
        var client = DataSource.Clients.FirstOrDefault(c => c.id == id);
        if (client == null)
        {
            LogManager.WriteToLog("error read client", "DalList", "Read");
            throw new DalEntityNotFoundException("Customer not exists");
        }
        LogManager.WriteToLog("end read client", "DalList", "Read");
        return client;
    }
    public Client? Read(Func<Client, bool>? filter = null)
    {
        LogManager.WriteToLog("start read product by filter", "DalList", "Read");
        var client = DataSource.Clients.FirstOrDefault(filter);
        if (client == null)
        {
            LogManager.WriteToLog("error read client by filter", "DalList", "Read");
            throw new DalEntityNotFoundException("Client not found with the given filter");
        }
        LogManager.WriteToLog("end read client by filter", "DalList", "Read");
        return client;
    }
    public List<Client?> ReadAll(Func<Client, bool>? filter = null)
    {
        LogManager.WriteToLog("read all products", "DalList", "ReadAll");
        if (filter == null)
            return DataSource.Clients.ToList();
        return DataSource.Clients.Where(filter).ToList();
    }
    //public List<Client> ReadAll()
    //{
    //    LogManager.WriteToLog("read all clients", "DalList", "ReadAll");
    //    return new List<Client>(DataSource.Clients);
    //}
    public void Update(Client item)
    {
        LogManager.WriteToLog("start update client", "DalList", "Update");
        var index = DataSource.Clients.FindIndex(c => c.id == item.id);
        if (index == -1)
        {
            LogManager.WriteToLog("error update client", "DalList", "Update");
            throw new DalEntityNotFoundException("Customer not exists");
        }
        DataSource.Clients[index] = item;
        LogManager.WriteToLog("end update client", "DalList", "Update");
    }
}