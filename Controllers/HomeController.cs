using corecart.Models;
using corecart.Services;
using Microsoft.AspNetCore.Mvc;

namespace corecart.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }
        public IActionResult Index()
        {
            return View(_restaurantData.GetAll());
        }
    }
    
}
