using System.Threading.Tasks;
using TravelCreation.Entities;

namespace TravelCreation.Repositories
{
    public interface IEllaAPI
    {
        public Task<List<Hotel>> spHotelSearchByRadius(decimal latitude, decimal longitude);
        public Task<List<RoomAvail>> spRoomGetAvailabilityByDateRange(DateTime StartDate, DateTime EndDate);
    }

}
