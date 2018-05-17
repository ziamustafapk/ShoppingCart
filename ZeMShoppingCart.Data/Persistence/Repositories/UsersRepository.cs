using System;
using System.Linq;
using ZeMShoppingCart.ExceptionManager;
using ZeMShoppingCart.Model;

namespace ZeMShoppingCart.Data
{
    public class UsersRepository : Repository<Users>, IUsersRepository
    {
        public UsersRepository(ShoppingCartDbContext context) : base(context)
        {
        }
        public ShoppingCartDbContext ShoppingCartDbContext => Context as ShoppingCartDbContext;

        public bool UserLoginAuthentication(string email, string password)
        {
            try
            {
                return Context.Users.
                    Any(u =>
                        u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)
                        && u.Password == password);
            }
            catch (Exception exception)
            {
                DataBaseExceptions.WriteExceptionMessageToFile(exception);
                return false;
            }
        }

        public Users UserSignIn(string email, string password)
        {
            try
            {
                return Context.Users.
                    FirstOrDefault(u =>
                        u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)
                        && u.Password == password);
            }
            catch (Exception exception)
            {
                DataBaseExceptions.WriteExceptionMessageToFile(exception);
                return null;
            }
        }
    }
}
