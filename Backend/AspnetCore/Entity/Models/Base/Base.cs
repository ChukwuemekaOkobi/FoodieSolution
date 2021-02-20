using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public class BaseEnity<T>
    {
        public T Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public BaseEnity()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
