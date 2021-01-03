using Exercises20_ORM_Relationships.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercises20_ORM_Relationships.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> Categories { get; set; }

        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options) {  }
    }
}
