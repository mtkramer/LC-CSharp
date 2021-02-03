using Exercise22_REST_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercise22_REST_API.Data
{
    public class CodingEventsDbContext : DbContext
    {
        public DbSet<CodingEvent> CodingEvents { get; set; }

        public CodingEventsDbContext(DbContextOptions options)
          : base(options) { }
    }
}
