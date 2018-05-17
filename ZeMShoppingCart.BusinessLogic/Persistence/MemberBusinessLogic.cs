using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
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

        public MemberBusinessLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public MemberViewModel GetMemberById(int memberId)
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
                var result = _unitOfWork.Member.GetAll();
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

        public MemberViewModel CreateMember(MemberViewModel memberViewModel)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    var member = new Member
                    {
                        
                        CreatedBy = memberViewModel.CreatedBy,
                        CreatedDate = DateTime.Now,
                        MemberType = memberViewModel.MemberType,
                        ModifiedBy = memberViewModel.ModifiedBy,
                        ModifiedDate = DateTime.Now,
                        Name = memberViewModel.Name
                       
                    };
                    _unitOfWork.Member.Add(member);
                    _unitOfWork.Complete();

                    scope.Complete();
                    return Mapper.Map<Member, MemberViewModel>(member);

                }
               
            }
            catch (Exception exception)
            {
                BusinessLogicExceptions.WriteExceptionMessageToFile(exception);
                return null;
            }
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
