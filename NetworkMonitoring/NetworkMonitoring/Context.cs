﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NetworkMonitoring
{
    public class Context:DbContext
    {

        public Context() : base("DbConnection"){ }

        public DbSet<ComputerInfo> ComputerInfos { get; set; }
    }
}
