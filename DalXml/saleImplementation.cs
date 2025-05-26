using DalApi;
using DO;
using System.Xml.Serialization;
using System.Xml.Linq;
namespace Dal;

internal class saleImplementation : ISale
{
    static string filePath = @"../xml/sales.xml";
    XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
    List<Sale> list;

    public int Create(Sale item)
    {
        if (item.onlyClub==true && item.productId > 0 && item.amountForGetSale > 0 && item.dateEndSale!=null && item.dateStartSale!=null)
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
        return 0;
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
        XElement saleXml = XElement.Load(filePath);
        // Locate the Sale element that matches the provided item's id
        var element = saleXml.Descendants("Sale")
                             .FirstOrDefault(sale => (int)sale.Element("id") == item.id);

        if (element == null)
            throw new KeyNotFoundException($"Sale with ID {item.id} not found.");

        // Update the properties of the found Sale element
        element.Element("productId").SetValue(item.productId);
        element.Element("amountForGetSale").SetValue(item.amountForGetSale);
        element.Element("sumPriceInSale").SetValue(item.sumPriceInSale);
        element.Element("onlyClub").SetValue(item.onlyClub);
        element.Element("dateStartSale").SetValue(item.dateStartSale);
        element.Element("dateEndSale").SetValue(item.dateEndSale);

        // Save the changes back to the XML file
        saleXml.Save(filePath);
    }





}
