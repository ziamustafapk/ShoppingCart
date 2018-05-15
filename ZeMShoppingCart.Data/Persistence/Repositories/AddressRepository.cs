using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
