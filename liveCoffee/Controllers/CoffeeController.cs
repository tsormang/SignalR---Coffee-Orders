using System.Web.Http;
using liveCoffee.Models;

namespace liveCoffee.Controllers
{
    public class CoffeeController : ApiController
    {
        private static int OrderId;

        [HttpPost]
        public int OrderCoffee(Order order)
        {
            OrderId++;
            return OrderId;
        }


    }
}