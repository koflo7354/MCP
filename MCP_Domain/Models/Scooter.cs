using System;
using System.Collections.Generic;
using System.Text;

namespace MCP_Domain.Models
{
    public class Scooter
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public float Battery_Capacity { get; set; }
        public Status Status { get; set; }
        public IEnumerable<Trip> Trips { get; set; }

    }
}
