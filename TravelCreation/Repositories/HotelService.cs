using TravelCreation.Data;
using  TravelCreation.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace TravelCreation.Repositories
{
    public class HotelService : IHotelService
    {
        private readonly DbContextClass _dbContextClass;
        public HotelService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Hotel>> RoomGetAvailyByDate(int hotelid)
        {
            var param = new SqlParameter("@hotelid", hotelid);
            var hotelRoomAvailyByDate = await Task.Run(() => _dbContextClass.Hotel.FromSqlRaw("execute spRoomGetAvailyByDate @hotelid", param).ToListAsync());
            return hotelRoomAvailyByDate;
        }
        

    }
}
