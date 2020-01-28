using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using liveCoffee.Connections;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(liveCoffee.Startup1))]

namespace liveCoffee
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            app.MapSignalR<CoffeeConnections>("/coffee");
            //GlobalHost.HubPipeline.RequireAuthentication();
        }
    }
}
