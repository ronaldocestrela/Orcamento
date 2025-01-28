namespace Orcamento.Domain.Entities
{
    public class Companey : BaseEntity
    {
        public Companey(string comapnyName, string comapnyCNPJ, string comapnyAddress, string comapnyPhone, string comapnyEmail, string companyLogoURL, int comapnyUserId, User comapnyUser)
        {
            ComapnyName = comapnyName;
            ComapnyCNPJ = comapnyCNPJ;
            ComapnyAddress = comapnyAddress;
            ComapnyPhone = comapnyPhone;
            ComapnyEmail = comapnyEmail;
            CompanyLogoURL = companyLogoURL;
            ComapnyUserId = comapnyUserId;
            ComapnyUser = comapnyUser;
        }

        public string ComapnyName { get; private set; }
        public string ComapnyCNPJ { get; private set; }
        public string ComapnyAddress { get; private set; }
        public string ComapnyPhone { get; private set; }
        public string ComapnyEmail { get; private set; }
        public string CompanyLogoURL { get; private set; }
        public int ComapnyUserId { get; private set; }
        public User ComapnyUser { get; private set; }
    }
}
