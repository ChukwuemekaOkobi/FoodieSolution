using System;
using System.Collections.Generic;
using System.Text;

namespace Utility.Base
{
    /// <summary>
    /// Base Entity for creating database entities and generic implementations
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Entity<T>
    {
        public T Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public Entity()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
