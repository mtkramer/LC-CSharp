﻿using Microsoft.EntityFrameworkCore;
using Reading21_Authentication.Models;

namespace Reading21_Authentication.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<EventTag> EventTags { get; set; }

        public EventDbContext(DbContextOptions<EventDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventTag>().HasKey(et => new { et.EventId, et.TagId });
        }
    }
}
