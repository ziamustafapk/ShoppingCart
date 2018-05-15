﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeMShoppingCart.Model;

namespace ZeMShoppingCart.Data
{
    public interface IMemberRepository :IRepository<Member>
    {
       IEnumerable<Member>  GetMemberWithEmail();
    }
}