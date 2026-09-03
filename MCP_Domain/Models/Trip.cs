using System;
using System.Collections.Generic;
using System.Text;

namespace MCP_Domain.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public DateTime Start_time { get; set; }
        public DateTime End_Time { get; set; }
        public int Distance { get; set; }
        public int Cost { get; set; }
        public int App_UserId { get; set; }
        public App_User user { get; set; }
        public int ScooterId { get; set; }
        public Scooter scooter { get; set; }
    }
}
