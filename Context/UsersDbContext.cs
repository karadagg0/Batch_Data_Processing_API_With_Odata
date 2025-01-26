using Batch_Data_Processing_API_With_Odata.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Batch_Data_Processing_API_With_Odata.Context
{
    public class UsersDbContext:DbContext
    {
        public DbSet<USERS> USERS { get; set; }
        public DbSet<ORDERS> ORDERS { get; set; }

        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ORDERS>()
                .HasOne(o => o.USER) 
                .WithMany(u => u.Orders) 
                .HasForeignKey(o => o.USER_ID);
        }
    }
}
