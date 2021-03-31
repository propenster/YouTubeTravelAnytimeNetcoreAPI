using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAnytimePublicAPI.Models;

namespace TravelAnytimePublicAPI.DAL
{
    public class DataContext  : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<HotelReview> HotelReviews { get; set; }
        public DbSet<RestaurantReview> RestaurantReviews { get; set; }
    }
}
