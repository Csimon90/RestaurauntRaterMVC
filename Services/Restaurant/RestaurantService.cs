using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantRaterMVC.Controllers.Data;
using RestaurantRaterMVC.Models;
using Microsoft.EntityFrameworkCore;


namespace RestaurantRaterMVC.Services.Restaurant
{
    public class RestaurantService
    {
        private RestaurantDbContext _context;
        public RestaurantService(RestaurantDbContext context)
        {
            _context = context;
        }
        public async Task<List<RestaurantListItem>> GetAllRestaurants()
        {
            List<RestaurantListItem> restaurants = _context.Restaurants;
            .Include(r => r.Ratings)
            .Select(r => new RestaurantListItem()
            {
                Id = r.Id,
                Name = r.Name,
                Score = r.Score,
            })await .ToListAsync;
            return restaurants; 
        }
        Restaurant restaurant = new Restaurant()
        {
            Name = model.Name,
            Location =model.Location,
        };
        _context.Restaurants.Add(restaurant);
        return await _context.SaveChangesAsync() ==1; 
    }
}
