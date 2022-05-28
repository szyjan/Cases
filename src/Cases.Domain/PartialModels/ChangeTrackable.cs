using Cases.Domain.Entities.Employees;

namespace Cases.Domain.PartialModels
{
    public abstract class ChangeTrackable
    {
        public DateTime CreatedDateUtc { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDateUtc { get; set; }
        public int ModifiedBy { get; set; }

        public virtual Employee CreatedByEmployee { get; set; }
        public virtual Employee ModifiedByEmployee { get; set; }
    }
}
