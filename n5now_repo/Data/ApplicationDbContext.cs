using Microsoft.EntityFrameworkCore;
using n5now_repo.Models;

namespace n5now_repo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<PermissionType> permissionTypes { get; set; }
    }
}
