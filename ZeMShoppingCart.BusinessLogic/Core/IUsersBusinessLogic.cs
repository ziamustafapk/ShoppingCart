using ZeMShoppingCart.ViewModel;

namespace ZeMShoppingCart.BusinessLogic
{
    public interface IUsersBusinessLogic
    {
        #region CustomMethods
        UsersViewModel UserSignIn(UserSignIn userSignIn);
        bool UserLoginAuthentication(UserSignIn userSignIn);
        #endregion
    }
}
