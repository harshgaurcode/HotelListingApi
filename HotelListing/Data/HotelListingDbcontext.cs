using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class HotelListingDbcontext: DbContext
    {

        public HotelListingDbcontext(DbContextOptions options):base(options) 
        {
            
        }
        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Country> Countries { get; set; }

       

    }
}
