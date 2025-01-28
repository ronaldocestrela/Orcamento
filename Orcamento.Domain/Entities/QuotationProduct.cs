namespace Orcamento.Domain.Entities
{
    public class QuotationProduct : BaseEntity
    {
        public int QuotationId { get; private set; }
        public Quotation Quotation { get; private set; }
        public int ProductId { get; private set; }
        public Product Product { get; private set; }
    }
}
