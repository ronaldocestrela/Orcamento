namespace Orcamento.Domain.Entities
{
    public class Carrier : BaseEntity
    {
        public string CarrierName { get; private set; }

        public Carrier(string carrierName)
        {
            CarrierName = carrierName;
        }
    }
}
