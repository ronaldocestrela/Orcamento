namespace Orcamento.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public Customer(int customerInternalKey, string customerName, string customerCnpj, string customerAddress, string customerCity, string customerState, string customerCountry, string customerZipCode, string customerPhone, string customerEmail, string customerContact)
        {
            CustomerInternalKey = customerInternalKey;
            CustomerName = customerName;
            CustomerCnpj = customerCnpj;
            CustomerAddress = customerAddress;
            CustomerCity = customerCity;
            CustomerState = customerState;
            CustomerCountry = customerCountry;
            CustomerZipCode = customerZipCode;
            CustomerPhone = customerPhone;
            CustomerEmail = customerEmail;
            CustomerContact = customerContact;
        }

        public int CustomerInternalKey { get; private set; }
        public string CustomerName { get; private set; }
        public string CustomerCnpj { get; private set; }
        public string CustomerAddress { get; private set; }
        public string CustomerCity { get; private set; }
        public string CustomerState { get; private set; }
        public string CustomerCountry { get; private set; }
        public string CustomerZipCode { get; private set; }
        public string CustomerPhone { get; private set; }
        public string CustomerEmail { get; private set; }
        public string CustomerContact { get; private set; }
    }
}
