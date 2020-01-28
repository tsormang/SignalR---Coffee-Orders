using liveCoffee.Models;
using System.Threading.Tasks;

namespace liveCoffee.Hubs
{
    public interface ICoffeeeClient
    {
        Task NewOrder(Order order);
        Task ReceiveOrderUpdate(UpdateInfo info);
        Task Finished(Order order);
    }
}