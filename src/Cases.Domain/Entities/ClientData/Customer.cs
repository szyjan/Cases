using Cases.Domain.Entities.Relations;
using Cases.Domain.PartialModels;

namespace Cases.Domain.Entities.ClientData
{
    public class Customer : ChangeTrackable
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;


        public virtual ICollection<CompanyCustomer> Companies { get; set; }
            = new List<CompanyCustomer>();

        public virtual ICollection<CaseCustomer> Cases { get; set; }
            = new List<CaseCustomer>();
    }
}
