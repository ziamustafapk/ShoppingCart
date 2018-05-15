using System;

namespace ZeMShoppingCart.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShoppingCartDbContext _context;
        //public UnitOfWork( ShoppingCartDbContext context)
        //{
        //    Member = new MemberRepository(context);
        //    Address = new AddressRepository(context);
        //    Email = new EmailRepository(context);
        //    _context = context;
        //}

        public UnitOfWork(ShoppingCartDbContext context, IMemberRepository member)
        {
            _context = context;
            Member = member;
            //Address = address;
           // Email = email;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IMemberRepository Member { get; }
        public IAddressRepository Address { get; private set; }
        public IEmailRepository Email { get; private set; }
        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}
