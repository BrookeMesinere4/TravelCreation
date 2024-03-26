using TravelCreation.Entities
using Microsoft.EntityFrameworkCore;

namespace TravelCreation.Data
{
    public class DbContextClass
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        { }

        public DbSet<Hotel> Hotel { get; set; }
    }
}
