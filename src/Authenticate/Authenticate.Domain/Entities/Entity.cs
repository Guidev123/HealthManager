﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthManager.Domain.Entities
{
    public abstract class Entity : IEquatable<Guid>
    {
        protected Entity() => Id = Guid.NewGuid();
        public Guid Id { get; private set; }

        public bool Equals(Guid id) => Id == id;
        public override int GetHashCode() => Id.GetHashCode();  
    }
}
