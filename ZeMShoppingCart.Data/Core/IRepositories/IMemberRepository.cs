using System.Collections.Generic;
using ZeMShoppingCart.Model;

namespace ZeMShoppingCart.Data
{
    public interface IMemberRepository :IRepository<Member>
    {
       IEnumerable<Member>  GetMemberWithEmail();
    }
}
