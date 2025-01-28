namespace Orcamento.Domain.Entities
{
    public class User : BaseEntity
    {
        public string  UserFulName { get; private set; }
        public string UserEmail { get; private set; }
        public string UserPassword { get; private set; }
        public string UserPhone { get; private set; }
        public string UserCPF { get; private set; }
        public string UserRole { get; private set; }
        public string UserActive { get; private set; }

        public List<Quotation> Budgets { get; private set; }
    }
}
