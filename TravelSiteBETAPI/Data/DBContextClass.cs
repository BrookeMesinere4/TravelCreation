using TravelSiteBETAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace TravelSiteBETAPI.Data
{
    public class DBContextClass : DbContext
    {
        public DBContextClass(DbContextOptions<DBContextClass> options) : base(options) 
        { }
        public DbSet<Hotel> Hotel { get; set; }

        public DbSet<HotelRatings> HotelRatings { get; set; }
    }
}
