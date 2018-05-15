using System.Collections.Generic;
using ZeMShoppingCart.ViewModel;

namespace ZeMShoppingCart.BusinessLogic
{
    public interface IMemberBusinessLogic
    {
        #region CustomMethods
        MemberViewModel GetMemberById(string memberId);
        IEnumerable<MemberViewModel> GetAllMembers();
        IEnumerable<MemberViewModel> GetAllMembersWithEmails();
        void CreateMember(MemberViewModel memberViewModel);
        bool UpdateMember(int memberId, MemberViewModel memberViewModel);

        bool DeleteMember(int memberId);
#endregion
    }
}
