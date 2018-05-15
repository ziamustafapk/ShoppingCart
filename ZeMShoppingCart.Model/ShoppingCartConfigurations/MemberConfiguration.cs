using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
