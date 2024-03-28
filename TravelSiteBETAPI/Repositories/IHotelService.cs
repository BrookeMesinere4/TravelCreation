using System.Threading.Tasks;
using TravelSiteBETAPI.Entities;

namespace TravelSiteBETAPI.Repositories
{
    public interface IHotelService
    {
        public Task<List<Hotel>> ReturnHotelDetails(int hotelid);
    }
}
