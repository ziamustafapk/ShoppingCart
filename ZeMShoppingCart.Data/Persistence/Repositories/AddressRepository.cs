using ZeMShoppingCart.Model;

namespace ZeMShoppingCart.Data.Persistence
{
    public class AddressRepository : Repository<Address> , IAddressRepository
    {
        public AddressRepository(ShoppingCartDbContext context) : base(context)
        {
        }
        public ShoppingCartDbContext ShoppingCartDbContext() => Context;
    }
}
