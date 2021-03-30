using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.Models
{
    public interface IHotelRepository
    {
        void Add(HotelModel hotel);
        IEnumerable<HotelModel> GetAll();
        HotelModel Find(int hotelId);
        HotelModel Remove(int hotelId);
        void Update(HotelModel hotel);
    }
}
