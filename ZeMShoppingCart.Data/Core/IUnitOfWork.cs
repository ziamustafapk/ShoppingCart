using System;

namespace ZeMShoppingCart.Data
{
    public interface IUnitOfWork : IDisposable
    {
        #region ShoppingCart Properties 
        IMemberRepository Member { get; }
        IAddressRepository Address { get; }
        IEmailRepository Email { get; }
       IUsersRepository Users { get; }

        #endregion

        #region Methods
        void Complete();

        #endregion

    }
}
