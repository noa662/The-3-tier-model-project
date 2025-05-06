using DalApi;

namespace DO;

public record Client(int id, string? name = null, string? adress = null, string? phone = null) 
{
    public Client() : this(0, null, null, null)
    {

    }

}
