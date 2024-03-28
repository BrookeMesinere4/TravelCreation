using TravelSiteBETAPI.Data;
using TravelSiteBETAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace TravelSiteBETAPI.Repositories
{
    public class HotelService : IHotelService
    {
        private readonly DBContextClass _dBContextClass;
        public HotelService(DBContextClass dbContextClass)
        {
            _dBContextClass = dbContextClass;
        }
        public async Task<List<Hotel>> ReturnHotelDetails(int hotelid)
        {
            var param = new SqlParameter("@hotelid", hotelid);
            var hotelDetails = await Task.Run(() => _dBContextClass.Hotel.FromSqlRaw("exec spReturnHotelDetails @hotelid", param).ToListAsync());
            return hotelDetails;
        }

        public async Task<List<Hotel>> ReturnRatings(int rating, int hotelid)
        {
            var param = new SqlParameter("@hotelid", hotelid);
            var hotelRatings = await Task.Run(() => _dBContextClass.Hotel.FromSqlRaw("exec spReturnRatings @hotelratings", param).ToListAsync());
            return hotelRatings;
        }

        public Task<List<Hotel>> ReturnRatings(int hotelid)
        {
            throw new NotImplementedException();
        }
    }
}
