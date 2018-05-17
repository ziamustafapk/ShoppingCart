using FluentValidation;
using FluentValidation.Attributes;

namespace ZeMShoppingCart.ViewModel
{
    [Validator(typeof(UserSignInValidator))]
    public class UserSignIn
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class UserSignInValidator : AbstractValidator<UserSignIn>
    {
        public UserSignInValidator()
        {
            RuleFor(u => u.UserName).NotNull().NotEmpty().WithMessage("The User Name cannot be blank.")
                .Length(0, 100).WithMessage("The Password cannot be more than 100 characters.")
                .EmailAddress();
            RuleFor(p => p.Password).NotNull().NotEmpty().WithMessage("The User Name cannot be blank.")
                .Length(0, 100).WithMessage("The Password cannot be more than 100 characters.");
        }
    }

}
