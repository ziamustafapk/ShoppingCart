using System;

namespace ZeMShoppingCart.ExceptionManager
{
    public interface IBusinessLogicExceptions
    {
        void WriteExceptionMessageToFile( Exception exception);
    }
}
