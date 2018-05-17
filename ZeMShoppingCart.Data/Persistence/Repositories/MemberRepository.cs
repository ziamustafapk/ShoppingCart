using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ZeMShoppingCart.ExceptionManager;
using ZeMShoppingCart.Model;

namespace ZeMShoppingCart.Data
{
    public class MemberRepository : Repository<Member>, IMemberRepository
    {
        public MemberRepository(ShoppingCartDbContext context) : base(context)
        {
        }
        public ShoppingCartDbContext ShoppingCartDbContext => Context as ShoppingCartDbContext;


        public IEnumerable<Member> GetMemberWithEmail()
        {
            try
            {
                var result = Context.Memberes.Include(m => m.Emails).ToList();
                return result;
            }
            catch (Exception exception)
            {
                DataBaseExceptions.WriteExceptionMessageToFile(exception);
                return null;
            }
        }
    }
}
