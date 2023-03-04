namespace IdentityApp
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public double InoviceAmount { get; set; }

        public string? InoviceMonth { get; set; }
        public string? InvoiceOwner { get; set; }
    }
}
