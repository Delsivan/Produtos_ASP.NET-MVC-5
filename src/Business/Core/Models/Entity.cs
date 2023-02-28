using System;

namespace Business.Core.Models
{
    // Uma classe mãe, ou seja uma classe abstrata, ela nao pode ser instanciada ela so pode ser herdada.
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
