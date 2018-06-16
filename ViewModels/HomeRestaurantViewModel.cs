using corecart.Models;
using System.Collections.Generic;

namespace corecart.ViewModels
{
    public class HomeRestaurantViewModel
    {
        public IEnumerable<Restaurant> resturants { get; set; }
        public string greeting { get; set; }
    }
}
