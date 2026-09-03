using System;
using System.Collections.Generic;
using System.Text;

namespace MCP_Domain.Models
{
    public class App_User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public IEnumerable<Trip>? Trips { get; set; }

        public App_User(string name)
        {
            Name = name;
            Trips = new List<Trip>();
        }
    }
}
