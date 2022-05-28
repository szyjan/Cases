using Cases.Domain.Entities.Cases;
using Cases.Domain.PartialModels;

namespace Cases.Domain.Entities.Employees
{
    public class Employee : ChangeTrackable
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public bool IsCourtAvailable { get; set; }


        public int? SupervisorId { get; set; }

        public virtual ICollection<Case> Cases { get; set; }
            = new List<Case>();

        public virtual Employee Supervisor { get; set; }

    }
}
