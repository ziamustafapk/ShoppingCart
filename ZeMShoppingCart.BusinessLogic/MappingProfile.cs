using AutoMapper;
using ZeMShoppingCart.Model;
using ZeMShoppingCart.ViewModel;

namespace ZeMShoppingCart.BusinessLogic
{
   public class MappingProfile :Profile
    {
       public MappingProfile()
       {

            CreateMap<Member, MemberViewModel>().ForMember(d => d.EmailViewModel, opt => opt.MapFrom(src => src.Emails ));
            CreateMap<Address, AddressViewModel>();
            CreateMap<Email, EmailViewModel>();
           CreateMap<Users, UsersViewModel>();
        }
    }
}
