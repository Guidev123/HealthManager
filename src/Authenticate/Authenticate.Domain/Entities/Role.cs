﻿using HealthManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticate.Domain.Entities
{
    public class Role : Entity
    {
        public string Name { get; set; } = string.Empty;
        public IEnumerable<User> Users { get; set; } = Enumerable.Empty<User>();
    }
}
