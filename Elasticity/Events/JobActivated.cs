﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elasticity.Events
{
    public class JobActivated : Event
    {
        public JobActivated()
        {            
        }

        public JobActivated(Guid jobId)
        {
            this.JobId = jobId;
        }

        public Guid JobId { get; set; }
    }
}
