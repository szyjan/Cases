using Cases.Domain.PartialModels;

namespace Cases.Domain.Entities.Cases
{
    public class Deadline : ChangeTrackable
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime DeadlineDate { get; set; }
        public bool IsActive { get; set; }
    }
}
