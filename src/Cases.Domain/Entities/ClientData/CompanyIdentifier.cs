using Cases.Domain.Enums;
using Cases.Domain.PartialModels;

namespace Cases.Domain.Entities.ClientData
{
    public class CompanyIdentifier : ChangeTrackable
    {
        public int CompanyId { get; set; }
        public string Identifier { get; set; } = string.Empty;
        public CompanyIdentifierType IdentifierType { get; set; }
    }
}
