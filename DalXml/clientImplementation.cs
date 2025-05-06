using DalApi;
using DO;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Dal;

internal class clientImplementation : IClient
{
    static string filePath = @"../xml/clients.xml";
    XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
    List<Client> list;

    public int Create(Client item)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Client>;
            list.Add(item);
        }
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            serializer.Serialize(sw, list);
        }
        return item.id;
    }

    public void Delete(int id)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Client>;
            list.Remove(list.FirstOrDefault(id => id == id));
        }
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            serializer.Serialize(sw, list);
        }
    }

    public Client Read(int id)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Client>;
        }
        return list.FirstOrDefault(c => c.id == id);
    }

    public Client? Read(Func<Client, bool> filter)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Client>;
        }
        return list.FirstOrDefault(filter);
    }

    public List<Client> ReadAll(Func<Client, bool>? filter = null)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Client>;
        }
        if (filter != null)
            return list?.Where(filter!).ToList() ?? throw new Exception();
        return list;
    }

    public void Update(Client item)
    {
        Delete(item.id);
        Create(item);
    }
}