using TravelSiteBETAPI.Entities;

namespace TravelSiteBETAPI.Repositories
{
    public class IRatingServiceBase
    {
        public Task<List<HotelRatings>> ReturnRatings(int hotelId);
        public new Task<List<HotelRatings>> ReturnRatings(int hotelid);
    }
}