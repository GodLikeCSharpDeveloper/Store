using Microsoft.EntityFrameworkCore;

namespace PCStore.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext()
        {

        }
        public StoreContext(DbContextOptions<StoreContext> options):base(options)
        {

        }
        public virtual DbSet<brandsModel> brands { get; set; }
        public virtual DbSet<categoryModel> categories { get; set; }
        public virtual DbSet<customersModel> customers { get; set; }
        public virtual DbSet<orderModel> orders { get; set; }
    }
}
