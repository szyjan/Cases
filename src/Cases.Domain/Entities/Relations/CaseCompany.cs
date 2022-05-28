using Cases.Domain.Entities.Cases;
using Cases.Domain.Entities.ClientData;

namespace Cases.Domain.Entities.Relations
{
    public class CaseCompany
    {
        public int CompanyId { get; set; }
        public int CaseId { get; set; }
        public bool IsPart { get; set; }

        public virtual Case Case { get; set; }
        public virtual Company Company { get; set; }
    }
}
