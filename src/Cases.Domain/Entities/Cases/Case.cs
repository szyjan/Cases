using Cases.Domain.Entities.Employees;
using Cases.Domain.Entities.Relations;
using Cases.Domain.Enums;
using Cases.Domain.PartialModels;

namespace Cases.Domain.Entities.Cases
{
    public class Case : ChangeTrackable
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public CaseStatus Status { get; set; }


        public virtual ICollection<CaseCustomer> Customers { get; set; } = new List<CaseCustomer>();
        public virtual ICollection<CaseCompany> Companies { get; set; } = new List<CaseCompany>();

        public virtual ICollection<CaseEmployee> CaseWorkers { get; set; } = new List<CaseEmployee>();

        public virtual ICollection<Deadline> Deadlines { get; set; } = new List<Deadline>();
        public virtual ICollection<Attachment> Attachemnts { get; set; } = new List<Attachment>();
    }
}
