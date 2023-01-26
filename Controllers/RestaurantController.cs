using Microsoft.AspNetCore.Mvc;

namespace RestaurantRateAPi.Controllers
{
    public class RestaurantController : Controller
    {
        private IRestaurantService _service;
        public RestaurantController(IRestaurantService service)
        {
            _service = service;
        }
    }
}