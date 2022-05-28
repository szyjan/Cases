using Cases.Domain.Entities.Cases;
using Cases.Domain.Entities.Employees;

namespace Cases.Domain.Entities.Relations
{
    public class CaseEmployee
    {
        public int CaseId { get; set; }
        public int EmployeeId { get; set; }
        public bool IsOwner { get; set; }

        public virtual Case Case { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
