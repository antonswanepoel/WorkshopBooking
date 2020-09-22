using Microsoft.EntityFrameworkCore;
using WorkshopBooking.Models;

namespace WorkshopBooking.Data
{
    public class WorkshopBookingContext : DbContext
    {
        public WorkshopBookingContext(DbContextOptions<WorkshopBookingContext> options)
            : base(options)
        {
        }
        public DbSet<VehicleBooking> Vehicles { get; set; }
    }
}
