using System;
using System.Collections.Generic;
using System.Text;

namespace Utility.Base
{
    public interface ISoftDelete
    {
        public bool IsSoftDeleted { get; set; }
    }
}
