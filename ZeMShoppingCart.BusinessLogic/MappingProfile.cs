using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
