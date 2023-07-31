namespace Casgem.ObserverDesingPattern.DAL
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public string DiscountCode { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool DiscountCodeStatus { get; set; }
    }
}
