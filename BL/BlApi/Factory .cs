using BlImplementation;
namespace BlApi;

public static class Factory
{
    public static IBl Get()
    {
        return new Bl();
    }
}
