using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeMShoppingCart.Model
{
    public class Email
    {
        public string Id { get; set; }
        public string Address { get; set; }
        public bool IsValidated { get; set; }
        public string Type { get; set; }
        public string MemberId { get; set; }

        public virtual Member Member { get; set; }
    }
}
