using System;
using ZeMShoppingCart.Data.Persistence;

namespace ZeMShoppingCart.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShoppingCartDbContext _context;
       

        public UnitOfWork(ShoppingCartDbContext context)
        {
            _context = context;
            Member = new MemberRepository(context);
            Address = new AddressRepository(context);
            Email = new EmailRepository(context);
            Users = new UsersRepository(context);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IMemberRepository Member { get; }
        public IAddressRepository Address { get; private set; }
        public IEmailRepository Email { get; private set; }
        public IUsersRepository Users { get; private set; }
        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}
