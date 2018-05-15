using System.Data.Entity.ModelConfiguration;

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
