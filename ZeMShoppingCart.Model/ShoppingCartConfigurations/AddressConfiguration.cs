using System.Data.Entity.ModelConfiguration;

namespace ZeMShoppingCart.Model
{
   public class AddressConfiguration : EntityTypeConfiguration<Address>
    {
       public AddressConfiguration()
       {
           ToTable("Address");
           HasKey(a => a.Id);
       }
    }
}
