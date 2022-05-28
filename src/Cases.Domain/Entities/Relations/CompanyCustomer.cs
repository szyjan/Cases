using Cases.Domain.Entities.ClientData;

namespace Cases.Domain.Entities.Relations
{
    public class CompanyCustomer
    {
        public int CompanyId { get; set; }
        public int CustomerId { get; set; }
        public bool IsMainRepresentative { get; set; }

        public virtual Company Company { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
