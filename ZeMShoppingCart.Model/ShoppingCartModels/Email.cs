namespace ZeMShoppingCart.Model
{
    public class Email
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public bool IsValidated { get; set; }
        public string Type { get; set; }
        public int MemberId { get; set; }

        public virtual Member Member { get; set; }
    }
}
