using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeMShoppingCart.ViewModel
{
    public class EmailViewModel
    {
        public string Id { get; set; }
        public string Address { get; set; }
        public bool IsValidated { get; set; }
        public string Type { get; set; }
        public string MemberId { get; set; }
    }
}
