using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using corecart.Data;
using corecart.Models;

namespace corecart.Services
{
    public class SqlRestaurant : IRestaurantData
    {
        private SqlDbContext _dbContext;

        public SqlRestaurant(SqlDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            _dbContext.Add(restaurant);
            _dbContext.SaveChanges();
            return restaurant;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _dbContext.resturants.OrderBy(r=>r.Name);
        }

        public Restaurant GetRestaurant(int id)
        {
            return _dbContext.resturants.FirstOrDefault(r => r.Id == id);
        }
    }
}
