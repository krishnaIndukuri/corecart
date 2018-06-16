using corecart.Services;
using corecart.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace corecart.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        private IGreeting _greeting;

        public HomeController(IRestaurantData restaurantData,IGreeting greeting)
        {
            _restaurantData = restaurantData;
            _greeting = greeting;
        }
        public IActionResult Index()
        {
            HomeRestaurantViewModel objviewModel = new HomeRestaurantViewModel()
            {
                resturants = _restaurantData.GetAll(),
                greeting = _greeting.getGreetings()
            };
            return View(objviewModel);
        }
    }
    
}
