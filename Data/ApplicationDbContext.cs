using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SignalRChat.Models.Chat;
using SignalRChat.Models.Users;

namespace SignalRChat.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("Chat");
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().ToTable("ApplicationUser");
            builder.Entity<ApplicationRole>().ToTable("ApplicationRole");
            builder.Entity<UserRole>().ToTable("UserRole");
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<Connection> Connections { get; set; }
    }
}
