namespace Orcamento.Domain.Entities
{
    public class PaymentMethod : BaseEntity
    {
        public string PaymentMethodName { get; private set; }

        public PaymentMethod(string paymentMethodName)
        {
            PaymentMethodName = paymentMethodName;
        }
    }
}
