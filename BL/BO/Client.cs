namespace BO;
public class Client
{
    public int id { get; init; }
    public string name { get; init; }
    public string? address { get; set; }
    public string? phone { get; set; }

    public Client()
    {
        id = 0;
        name = null;
        address = null;
        phone = null;
    }

    public Client(int id, string name, string? address, string? phone)
    {
        this.id = id;
        this.name = name;
        this.address = address;
        this.phone = phone;
    }
    public string ToString() => $"id: {id} name: {name} address: {address} phone: {phone}";
}
