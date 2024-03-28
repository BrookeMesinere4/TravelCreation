using System.Threading.Tasks;
using TravelSiteBETAPI.Entities;

namespace TravelSiteBETAPI.Repositories
{
    public class IRatingService
    {
        public Task<List<Hotel>> ReturnRatings(int hotelid);
    }
}
