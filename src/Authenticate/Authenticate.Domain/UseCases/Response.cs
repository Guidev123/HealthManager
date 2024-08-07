﻿using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticate.Domain.UseCases
{
    public abstract class Response
    {
        public string Message { get; set; } = string.Empty;
        public int Status { get; set; } = 200;
        public bool IsSuccess => Status is >= 200 and <= 299;
        public IEnumerable<Notification>? Notifications { get; set; }

    }
}
