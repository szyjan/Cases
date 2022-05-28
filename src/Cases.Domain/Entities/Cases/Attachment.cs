using Cases.Domain.PartialModels;

namespace Cases.Domain.Entities.Cases
{
    public class Attachment : ChangeTrackable
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public string Name { get; set; } = string.Empty;
        public byte[] Data { get; set; } = new byte[0];
    }
}
