using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public virtual Guid Id { get; set; }
    }
}