using Microsoft.EntityFrameworkCore;
using Reading19_ORM.Models;

namespace Reading19_ORM.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options) { }

    }
}
