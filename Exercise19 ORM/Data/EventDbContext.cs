using Exercise19_ORM.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercise19_ORM.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {
        }
    }
}
