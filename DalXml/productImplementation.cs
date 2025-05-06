using DalApi;
using DO;
using System.Xml.Linq;

namespace Dal;

internal class productImplementation : IProduct
{
    static string filePath = @"../xml/products.xml";

    public int Create(Product item)
    {
        XElement productXml = XElement.Load(filePath);
        int nextId = Config.ProductIdCounter;
        var arr = productXml.Element("ArrayOfProduct");
        if (arr == null)
        {
            arr = new XElement("ArrayOfProduct");
            productXml.Add(arr);
        }
        arr.Add(new XElement("Product",
            new XElement("Id", nextId),
            new XElement("Name", item.name),
            new XElement("Price", item.price),
            new XElement("Amount", item.amount),
            new XElement("Category", item.category)));
        productXml.Save(filePath);
        return nextId;
    }
    public void Delete(int id)
    {
        XElement productXml = XElement.Load(filePath);
        productXml.Descendants("Id").First(p => int.Parse(p.Value) == id).Parent.Remove();
        productXml.Save(filePath);
    }
    public Product Read(int id)
    {
        XElement productXml = XElement.Load(filePath);
        XElement xml = productXml.Descendants("Id").First(p => int.Parse(p.Value) == id).Parent;
        Product p = new Product(int.Parse(xml.Element("Id").Value),
                                xml.Element("Name").Value,
                                double.Parse(xml.Element("Price").Value),
                                int.Parse(xml.Element("Amount").Value),
                                (Category)Enum.Parse(typeof(Category), xml.Element("Category").Value));
        return p;
    }
    public Product? Read(Func<Product, bool> filter)
    {
        XElement productXml = XElement.Load(filePath);
        var products = productXml.Descendants("Product")
            .Select(p => new Product(
                    int.Parse(p.Element("Id").Value),
                    p.Element("Name").Value,
                    double.Parse(p.Element("Price").Value),
                    int.Parse(p.Element("Amount").Value),
                    (Category)Enum.Parse(typeof(Category), p.Element("Category").Value)));
        return products.FirstOrDefault(filter);
    }
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        XElement productXml = XElement.Load(filePath);
        var products = productXml.Descendants("Product")
            .Select(p => new Product(
                    int.Parse(p.Element("Id").Value),
                    p.Element("Name").Value,
                    double.Parse(p.Element("Price").Value),
                    int.Parse(p.Element("Amount").Value),
                    (Category)Enum.Parse(typeof(Category), p.Element("Category").Value))).ToList();
        return filter != null ? products.Where(filter).ToList() : products;
    }
    public void Update(Product item)
    {
        XElement productXml = XElement.Load(filePath);
        XElement s = productXml.Descendants("Id").First(id => int.Parse(id.Value) == item.id).Parent;
        s.Element("Price").SetValue(item.price);
        s.Element("Name").SetValue(item.name);
        s.Element("Amount").SetValue(item.amount);
        s.Element("Category").SetValue(item.category);
        productXml.Save(filePath);
    }
}
