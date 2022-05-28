using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cases.Domain.Enums
{
    public enum CaseStatus
    {
        Draft = 0,
        New = 1,
        InProgress = 2,
        Closed = 3,
        ClosedAppealed = 4
    }
}
