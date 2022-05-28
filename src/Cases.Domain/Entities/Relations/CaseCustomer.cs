using Cases.Domain.Entities.Cases;
using Cases.Domain.Entities.ClientData;

namespace Cases.Domain.Entities.Relations
{
    public class CaseCustomer
    {
        public int CustomerId { get; set; }
        public int CaseId { get; set; }
        public bool IsMainCustomer { get; set; }

        public virtual Case Case { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
