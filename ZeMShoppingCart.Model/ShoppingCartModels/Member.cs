using System;
using System.Collections.Generic;

namespace ZeMShoppingCart.Model
{
    public class Member
    {
        public Member()
        {
            Addresses = new HashSet<Address>();
            Emails = new HashSet<Email>();
           
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string MemberType { get; set; }
        public string Name { get; set; }

        
        public virtual ICollection<Address> Addresses { get; set; }
        
        public virtual ICollection<Email> Emails { get; set; }
       
    }


}
