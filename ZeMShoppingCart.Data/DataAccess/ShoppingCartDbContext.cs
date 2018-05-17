using System.Data.Entity;
using System.Diagnostics;
using ZeMShoppingCart.Model;

namespace ZeMShoppingCart.Data
{
    public class ShoppingCartDbContext : DbContext
    {

        #region Constructor

        public ShoppingCartDbContext()  
            :base("name=ShoppingCartDbContext")
        {
            //Disable initializer
            Database.SetInitializer<ShoppingCartDbContext>(null);
            //this.Configuration.LazyLoadingEnabled = false;
            Database.Log = sql => Debug.Write(sql);
        }
        #endregion

        #region Properties
        public virtual DbSet<Member> Memberes { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        #endregion

        #region ModelConfigurations
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberConfiguration());
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new EmailConfiguration());
            modelBuilder.Configurations.Add(new UsersConfiguration());

        }
        #endregion
    }
}
