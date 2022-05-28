using Cases.Domain.PartialModels;

namespace Cases.Domain.Entities.Cases
{
    public class Comment : ChangeTrackable
    {
        public int Id { get; set; }
        public string Body { get; set; } = string.Empty;

        public virtual ICollection<Attachment> Attachemnts { get; set; }
            = new List<Attachment>();
    }
}
