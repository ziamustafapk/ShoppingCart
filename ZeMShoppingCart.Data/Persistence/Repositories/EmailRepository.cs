using ZeMShoppingCart.Model;

namespace ZeMShoppingCart.Data.Persistence
{
    public class EmailRepository : Repository<Email>, IEmailRepository
    {
        public EmailRepository(ShoppingCartDbContext context) : base(context)
        {
        }

        public ShoppingCartDbContext ShoppingCartDbContext () => Context as ShoppingCartDbContext;
    }
}
