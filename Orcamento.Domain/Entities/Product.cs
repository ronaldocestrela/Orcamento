namespace Orcamento.Domain.Entities
{
    public class Product : BaseEntity
    {
        public Product(string productInternalKey, string productName, decimal productPrice, float productWeight)
        {
            ProductInternalKey = productInternalKey;
            ProductName = productName;
            ProductPrice = productPrice;
            ProductWeight = productWeight;
        }

        public string ProductInternalKey { get; private set; }
        public string ProductName { get; private set; }
        public Decimal ProductPrice { get; private set; }
        public float ProductWeight { get; private set; }
    }
}
