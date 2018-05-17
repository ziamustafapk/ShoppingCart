using System.Data.Entity.ModelConfiguration;

namespace ZeMShoppingCart.Model
{
    public class UsersConfiguration :EntityTypeConfiguration<Users>
    {
        public UsersConfiguration()
        {
            ToTable("Users");
            HasKey(u => u.UserId);
        }
    }
}
