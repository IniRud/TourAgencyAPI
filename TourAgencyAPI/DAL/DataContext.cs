using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourAgencyAPI.Models;

namespace TourAgencyAPI.DAL
{
    public class DataContext : DbContext
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
