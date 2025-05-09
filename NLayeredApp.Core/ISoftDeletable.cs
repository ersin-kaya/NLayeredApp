using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredApp.Core
{
    public interface ISoftDeletable
    {
        DateTimeOffset? DeletedAt { get; set; }
        string? DeletedBy { get; set; }
        bool IsDeleted { get; set; }
    }
}
