﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeMShoppingCart.ExceptionManager
{
    public interface IDataBaseExceptions
    {
        void WriteExceptionMessageToFile( Exception exception);
    }
}