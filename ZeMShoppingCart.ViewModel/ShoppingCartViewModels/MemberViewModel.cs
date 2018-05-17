using System;
using System.Collections.Generic;
using FluentValidation;
using FluentValidation.Attributes;
using ZeMShoppingCart.ViewModel.Validator;

namespace ZeMShoppingCart.ViewModel
{
    [Validator(typeof(MemberValidator))]
    public class MemberViewModel
    {
       
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string MemberType { get; set; }
        public string Name { get; set; }
        public virtual ICollection<EmailViewModel> EmailViewModel { get; set; }
    }

    public class MemberValidator : AbstractValidator<MemberViewModel>
    {
        public MemberValidator()
        {
            RuleFor(m => m.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage(ValidationErrorMessage.MemberErrors.MemberName)
                .Length(0,100).WithMessage(ValidationErrorMessage.MemberErrors.MemberNameLength);
        }
    }


    public class MemberEmailViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string MemberType { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
    }


}
