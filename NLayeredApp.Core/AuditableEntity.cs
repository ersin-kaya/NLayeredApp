using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredApp.Core
{
    public abstract class AuditableEntity : BaseEntity
    {
        public DateTimeOffset CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTimeOffset? LastModifiedAt { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
