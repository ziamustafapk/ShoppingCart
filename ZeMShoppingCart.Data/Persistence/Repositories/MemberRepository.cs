using System;
using System.Collections.Generic;
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
                var result = Context.Memberes;
                return result;


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
