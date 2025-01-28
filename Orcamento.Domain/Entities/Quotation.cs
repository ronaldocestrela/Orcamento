namespace Orcamento.Domain.Entities
{
    public class Quotation : BaseEntity
    {
        public DateTime QuotationDate { get; private set; }
        public int CustomerId { get; private set; }
        public Customer QuotationCustomer { get; private set; }
        public ICollection<QuotationProduct> QuotationProducts { get; private set; }
    }
}
