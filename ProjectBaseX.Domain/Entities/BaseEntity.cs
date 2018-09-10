using System;

namespace ProjectBaseX.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime? CreationDate { get; set; }
    }
}
