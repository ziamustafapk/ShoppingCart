using System;

namespace ZeMShoppingCart.ExceptionManager
{
    public interface IDataBaseExceptions
    {
        void WriteExceptionMessageToFile( Exception exception);
    }
}
