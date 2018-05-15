using AutoMapper;
using ZeMShoppingCart.Model;
using ZeMShoppingCart.ViewModel;

namespace ZeMShoppingCart.BusinessLogic
{
   public class MappingProfile :Profile
    {
       public MappingProfile()
       {
            CreateMap<Member, MemberViewModel>();
            CreateMap<Address, AddressViewModel>();
            CreateMap<Email, EmailViewModel>();

        }
    }
}
