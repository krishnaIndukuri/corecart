using corecart.Models;
using System.Collections.Generic;

namespace corecart.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant GetRestaurant(int id);
    }

}
