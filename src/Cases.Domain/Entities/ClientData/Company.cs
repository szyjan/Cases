using Cases.Domain.Entities.Relations;
using Cases.Domain.PartialModels;

namespace Cases.Domain.Entities.ClientData
{
    public class Company : ChangeTrackable
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;


        public virtual ICollection<CompanyCustomer> Representatives { get; set; }
            = new List<CompanyCustomer>();

        public virtual ICollection<CompanyIdentifier> CompanyIdentifiers { get; set; }
            = new List<CompanyIdentifier>();

        public virtual ICollection<CaseCompany> Cases { get; set; } = new List<CaseCompany>();
    }
}
