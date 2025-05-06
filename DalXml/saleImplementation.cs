using DalApi;
using DO;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Dal;

internal class saleImplementation : ISale
{
    static string filePath = @"../xml/sales.xml";
    XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
    List<Sale> list;

    public int Create(Sale item)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Sale>;
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
            list = serializer.Deserialize(sr) as List<Sale>;
            list.Remove(list.FirstOrDefault(id => id == id));
        }
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            serializer.Serialize(sw, list);
        }
    }

    public Sale Read(int id)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Sale>;
        }
        return list.FirstOrDefault(c => c.id == id);
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Sale>;
        }
        return list.FirstOrDefault(filter);
    }

    public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Sale>;
        }
        if (filter != null)
            return list?.Where(filter!).ToList() ?? throw new Exception();
        return list;
    }

    public void Update(Sale item)
    {
        Delete(item.id);
        Create(item);
    }
}
