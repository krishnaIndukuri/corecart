using corecart.Models;
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
        public IActionResult Detail(int Id)
        {
            Restaurant restaurant = _restaurantData.GetRestaurant(Id);
            if (restaurant == null)
            {
                return RedirectToAction("Index");
            }
            return View(restaurant);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateRestaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                Restaurant _restaurant = new Restaurant()
                {
                    Name = restaurant.Name,
                    Cousin = restaurant.Cousin
                };
                _restaurant = _restaurantData.AddRestaurant(_restaurant);

                return RedirectToAction("Detail", new { Id = _restaurant.Id });
            }
            else
            {
                return View();
            }
        }

    }
    
}
