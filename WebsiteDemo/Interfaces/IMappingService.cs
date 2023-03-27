namespace WebsiteDemo.Interfaces
{
    public interface IMappingService
    {
        TReturn MapContent<T, TReturn>(T content) where T : class;

    }
}