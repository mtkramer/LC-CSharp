using Exercise19_Persistent_Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercise19_Persistent_Data.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {
        }
    }
}
