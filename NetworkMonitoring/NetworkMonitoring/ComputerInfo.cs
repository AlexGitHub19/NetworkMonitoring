using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoring
{
    public class ComputerInfo
    {
        public int Id { get; set; }
        public string IpAddress { get; set; }
        public Status Status { get; set; }
    }

    public enum Status
    {
        online = 1,
        offline
    }
}
