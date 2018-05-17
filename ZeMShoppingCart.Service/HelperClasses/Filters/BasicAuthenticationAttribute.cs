using System;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Mvc;
using ZeMShoppingCart.BusinessLogic;
using ZeMShoppingCart.ViewModel;

namespace ZeMShoppingCart.Service.HelperClasses.Filters
{
    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
    {
        private readonly IUsersBusinessLogic _usersBusinessLogic = DependencyResolver.Current.GetService<IUsersBusinessLogic>();

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request
                    .CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                var authenticationToken = actionContext.Request.Headers
                    .Authorization.Parameter;
                var decodedAuthenticationToken = Encoding.UTF8.GetString(
                    Convert.FromBase64String(authenticationToken));
                var usernamePasswordArray = decodedAuthenticationToken.Split(':');
                var userSignIn = new UserSignIn
                {
                    UserName = usernamePasswordArray[0],
                    Password = usernamePasswordArray[1]
                };

                if (_usersBusinessLogic.UserLoginAuthentication(userSignIn))
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(
                        new GenericIdentity(userSignIn.UserName), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request
                        .CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
        }

    }
}