using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace liveCoffee.Connections
{
    public class CoffeeConnections : PersistentConnection
    {
        protected override async Task OnReceived(IRequest request, string connectionId, string data)
        {
            await base.OnReceived(request, connectionId, data);
        }

        protected override Task OnConnected(IRequest request, string connectionId)
        {
            return base.OnConnected(request, connectionId);
        }

        protected override bool AuthorizeRequest(IRequest request)
        {
            return request.User.Identity.IsAuthenticated;
        }
    }
}