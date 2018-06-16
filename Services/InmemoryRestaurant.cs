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
                new Restaurant{Id=201,Name="Restaurant1"},
                new Restaurant{Id=202,Name="Restaurant2"},
                new Restaurant{Id=203,Name="Restaurant3"},
                new Restaurant{Id=204,Name="Restaurant4"},
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return Restaurants;
        }

        List<Restaurant> Restaurants;
    }
}
