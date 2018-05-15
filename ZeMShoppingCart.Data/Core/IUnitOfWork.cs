using System;

namespace ZeMShoppingCart.Data
{
    public interface IUnitOfWork : IDisposable
    {
        #region GreeterApp Properties 
        IMemberRepository Member { get; }
        IAddressRepository Address { get; }
        IEmailRepository Email { get; }
       

        #endregion

        #region Methods
        void Complete();

        #endregion

    }
}
