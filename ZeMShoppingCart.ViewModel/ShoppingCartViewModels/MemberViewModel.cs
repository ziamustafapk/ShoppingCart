using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Attributes;

namespace ZeMShoppingCart.ViewModel
{
    [Validator(typeof(MemberValidator))]
    public class MemberViewModel
    {
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string MemberType { get; set; }
        public string Name { get; set; }
    }

    public class MemberValidator : AbstractValidator<MemberViewModel>
    {
        public MemberValidator()
        {
            RuleFor(m => m.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Member Name can not be blank.")
                .Length(0,100).WithMessage("Member Name should be between 0 to 100 chracters.");
        }
    }
}
