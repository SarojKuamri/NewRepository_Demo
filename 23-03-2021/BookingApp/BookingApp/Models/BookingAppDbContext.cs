using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.Models
{
    public class BookingAppDbContext:DbContext
    {
        public BookingAppDbContext(DbContextOptions<BookingAppDbContext> options):base(options)
        {

        }
        public DbSet<HotelModel> hotelModels { get; set; }
    }
}
