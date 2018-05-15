using System;

namespace ZeMShoppingCart.ExceptionManager
{
    public interface ICustomExceptions
    {
        void WriteExceptionMessageToFile( Exception exception);
    }
}
