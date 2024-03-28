using TravelSiteBETAPI.Data;
using TravelSiteBETAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace TravelSiteBETAPI.Repositories
{
    public class RatingService : IRatingService
    {
        private readonly DBContextClass _dbContext;
        public RatingService(DBContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<HotelRatings>> ReturnRatings(int hotelid)
        {
            var param = new SqlParameter("HotelID", hotelid);
            var hotelRatings = await Task.Run(() => _dbContext.HotelRatings.FromSqlRaw("spReturnRatings @HotelID", param).ToListAsync());
            return hotelRatings;
        }
    }
}
