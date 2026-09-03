using System;
using System.Collections.Generic;
using System.Text;

namespace MCP_Domain.Models
{
    public class UserOnScooter
    {
        public int Id {  get; set; }
        public int ScooterId {  get; set; }
        public Scooter Scooter { get; set; }
        public int App_UserId { get; set; }
        public App_User user { get; set; }
    }
}
