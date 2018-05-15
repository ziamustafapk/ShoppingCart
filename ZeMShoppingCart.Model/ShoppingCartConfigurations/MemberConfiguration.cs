using System.Data.Entity.ModelConfiguration;

namespace ZeMShoppingCart.Model
{
   public class MemberConfiguration : EntityTypeConfiguration<Member>
    {
       public MemberConfiguration()
       {
           ToTable("Member");
           HasKey(m => m.Id);
       }
    }
}
