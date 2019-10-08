using api.Models.EntityModel.Searches;
using api.Models.EntityModel.Sports;
using api.Models.EntityModel.Users;
using Microsoft.EntityFrameworkCore;

namespace Talentos.API.Data
{
    public class Context : DbContext
    {
        
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
        public DbSet<Sport> Sports { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Search> Searches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SportMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new SearchMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}