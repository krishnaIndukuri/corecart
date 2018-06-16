using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using corecart.Models;

namespace corecart.Services
{
    public class InmemoryRestaurant : IRestaurantData
    {
        public InmemoryRestaurant()
        {
            Restaurants = new List<Restaurant>() {
                new Restaurant{Id=201,Name="Restaurant1",Cousin=CousinType.Chineese},
                new Restaurant{Id=202,Name="Restaurant2",Cousin=CousinType.Indian},
                new Restaurant{Id=203,Name="Restaurant3",Cousin=CousinType.French},
                new Restaurant{Id=204,Name="Restaurant4",Cousin=CousinType.Indian},
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return Restaurants;
        }

        public Restaurant GetRestaurant(int id)
        {
            return Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            restaurant.Id = Restaurants.Max(r => r.Id) + 1;
            Restaurants.Add(restaurant);
            return restaurant;
        }

        List<Restaurant> Restaurants;
    }
}
