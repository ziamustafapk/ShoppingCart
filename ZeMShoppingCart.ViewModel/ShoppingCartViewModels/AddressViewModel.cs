using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeMShoppingCart.ViewModel
{
    public class AddressViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string CountryCode { get; set; }
        public string StateProvince { get; set; }
        public string CountryName { get; set; }
        public string PostalCode { get; set; }
        public string RegionId { get; set; }
        public string RegionName { get; set; }
        public string Type { get; set; }
        public string DaytimePhoneNumber { get; set; }
        public string EveningPhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public string Organization { get; set; }
        public string MemberId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
