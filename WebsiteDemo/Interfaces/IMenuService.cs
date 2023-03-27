using WebsiteDemo.Models;

namespace WebsiteDemo.Interfaces
{
    public interface IMenuService
    {
        IEnumerable<MenuItem> GetHeaderMenu();
    }
}