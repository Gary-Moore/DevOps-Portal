﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Portal.Domain.Teamcity
{

    public class VcsProperites
    {
        public int Count { get; set; }
        public IEnumerable<VcsProperty> Property { get; set; }
    }

}
