using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Studio21_Authentication.Models;

namespace Studio21_Authentication.Data
{
    public class JobDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Job> Jobs { get; set; }

        public JobDbContext(DbContextOptions<JobDbContext> options) : base(options) {  }
    }

}
