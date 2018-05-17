using System;
using AutoMapper;
using ZeMShoppingCart.Data;
using ZeMShoppingCart.ExceptionManager;
using ZeMShoppingCart.Model;
using ZeMShoppingCart.ViewModel;

namespace ZeMShoppingCart.BusinessLogic
{
    public class UsersBusinessLogic : IUsersBusinessLogic
    {
        private readonly UnitOfWork _unitOfWork;

        public UsersBusinessLogic(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool UserLoginAuthentication(UserSignIn userSignIn)
        {
            try
            {
                return 
                    _unitOfWork
                        .Users
                            .UserLoginAuthentication(userSignIn.UserName, userSignIn.Password);
            }
            catch (Exception exception)
            {
                BusinessLogicExceptions.WriteExceptionMessageToFile(exception);
                return false;
            }
        }

        public UsersViewModel UserSignIn(UserSignIn userSignIn)
        {
            try
            {
                return
                    Mapper.Map<Users, UsersViewModel>
                        (_unitOfWork
                        .Users
                        .UserSignIn(userSignIn.UserName, userSignIn.Password));
;
            }
            catch (Exception exception)
            {
                BusinessLogicExceptions.WriteExceptionMessageToFile(exception);
                return null;
            }
        }
    }
}
