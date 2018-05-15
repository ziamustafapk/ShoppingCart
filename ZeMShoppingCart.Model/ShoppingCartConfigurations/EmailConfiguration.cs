using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ZeMShoppingCart.Model
{
  public  class EmailConfiguration :EntityTypeConfiguration<Email>

    {
      public EmailConfiguration()
      {
          ToTable("Email");
          HasKey(e => e.Id);
      }
    }
}
