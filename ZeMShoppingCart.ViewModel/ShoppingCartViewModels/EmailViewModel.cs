namespace ZeMShoppingCart.ViewModel
{
    public class EmailViewModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public bool IsValidated { get; set; }
        public string Type { get; set; }
        public int MemberId { get; set; }
        public virtual MemberViewModel MemberViewModel { get; set; }
    }
}
