using System.Xml.Linq;

namespace Dal;

internal static class Config
{
    static string filePath = @"../xml/data-config.xml";
    public static int ProductIdCounter
    {
        get
        {
            XElement configXml = XElement.Load(filePath);
            int x = int.Parse(configXml.Element("ProductIdCounter").Value);
            configXml.Element("ProductIdCounter").SetValue(x + 5);
            configXml.Save(filePath);
            return x;
        }
    }
    public static int SaleIdCounter
    {
        get
        {
            XElement configXml = XElement.Load(filePath);
            int x= int.Parse(configXml.Element("SaleIdCounter").Value);
            configXml.Element("SaleIdCounter").SetValue(x + 5);
            configXml.Save(filePath);
            return x;
        }
    }
}
