using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
