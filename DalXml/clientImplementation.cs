using DalApi;
using DO;
using System.Xml.Serialization;
using System.Xml.Linq;

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
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                list = serializer.Deserialize(sr) as List<Client>;
                list.Remove(list.FirstOrDefault(item => item.id == id));
            }
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, list);
            }
        }
        catch(Exception ex)
        {
            throw new Exception("הלקוח לא נמחק");
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
        XElement clientXML = XElement.Load(filePath);
        var element = clientXML.Descendants("Client")
                             .FirstOrDefault(sale => (int)sale.Element("id") == item.id);
        if (element == null)
            throw new KeyNotFoundException($"Sale with ID {item.id} not found.");
        element.Element("id").SetValue(item.id);
        element.Element("name").SetValue(item.name);
        element.Element("adress").SetValue(item.adress);
        element.Element("phone").SetValue(item.phone);
        clientXML.Save(filePath);
    }
}