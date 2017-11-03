using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventManagement.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime EventDate { get; set; }
    }
}