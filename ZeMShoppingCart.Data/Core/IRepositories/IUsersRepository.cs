using ZeMShoppingCart.Model;

namespace ZeMShoppingCart.Data
{
    public interface IUsersRepository : IRepository<Users>
    {
        Users UserSignIn(string email, string password);
        bool UserLoginAuthentication(string email, string password);
    }
}
