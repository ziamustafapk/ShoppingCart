using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ZeMShoppingCart.Data;
using ZeMShoppingCart.ExceptionManager;
using ZeMShoppingCart.Model;
using ZeMShoppingCart.ViewModel;

namespace ZeMShoppingCart.BusinessLogic
{
    public class MemberBusinessLogic : IMemberBusinessLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IMemberRepository _memberRepository;

        public MemberBusinessLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
           // _memberRepository = member;
        }

        public MemberViewModel GetMemberById(string memberId)
        {
            try
            {
                return
                   Mapper.Map<Member, MemberViewModel>
                   (_unitOfWork.Member.Find(m => m.Id == memberId).FirstOrDefault());
            }
            catch (Exception exception)
            {
                BusinessLogicExceptions.WriteExceptionMessageToFile(exception);
                return null;
            }
        }

        public IEnumerable<MemberViewModel> GetAllMembers()
        {
            try
            {
                return
                   Mapper.Map< IEnumerable<Member>, IEnumerable<MemberViewModel>>
                   (_unitOfWork.Member.GetAll());
            }
            catch (Exception exception)
            {
                BusinessLogicExceptions.WriteExceptionMessageToFile(exception);
                return null;
            }
        }
        public IEnumerable<MemberViewModel> GetAllMembersWithEmails()
        {
            try
            {
                return
                    Mapper.Map<IEnumerable<Member>, IEnumerable<MemberViewModel>>
                        (_unitOfWork.Member.GetMemberWithEmail());
            }
            catch (Exception exception)
            {
                BusinessLogicExceptions.WriteExceptionMessageToFile(exception);
                return null;
            }
        }

        public void CreateMember(MemberViewModel memberViewModel)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMember(int memberId, MemberViewModel memberViewModel)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMember(int memberId)
        {
            throw new NotImplementedException();
        }
    }
}
