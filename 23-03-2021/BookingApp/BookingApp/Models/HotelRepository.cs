using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.Models
{
    public class HotelRepository : IHotelRepository
    {
        private readonly BookingAppDbContext _bookingAppDbContext;
        public HotelRepository(BookingAppDbContext bookingAppDbContext)
        {
            _bookingAppDbContext = bookingAppDbContext;
        }
       
      
        public void Add(HotelModel hotel)
        {          
            _bookingAppDbContext.hotelModels.Add(hotel);
            _bookingAppDbContext.SaveChanges();
        }

        public HotelModel Find(int hotelId)
        {
           var hotel= _bookingAppDbContext.hotelModels.Find(hotelId);
           return hotel;
        }

        public IEnumerable<HotelModel> GetAll()
        {
            return _bookingAppDbContext.hotelModels.ToList();
        }

        public HotelModel Remove(int hotelId)
        {
            var hotelEntity = Find(hotelId);
            _bookingAppDbContext.hotelModels.Remove(hotelEntity);
            _bookingAppDbContext.SaveChanges();
            return hotelEntity;
        }

        public void Update(HotelModel hotel)
        {
            _bookingAppDbContext.Entry(hotel).State = EntityState.Modified;
            _bookingAppDbContext.SaveChanges();
        }
    }
}
