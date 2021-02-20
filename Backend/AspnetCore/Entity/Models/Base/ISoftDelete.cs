using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public interface ISoftDelete
    {
        public bool IsSoftDeleted { get; set; }
    }
}
