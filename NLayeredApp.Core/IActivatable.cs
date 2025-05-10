using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredApp.Core
{
    public interface IActivatable
    {
        bool IsActive { get; set; }
    }
}
