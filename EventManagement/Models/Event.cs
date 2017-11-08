﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventManagement.Models
{
    public partial class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public System.DateTime EventDate { get; set; }
        public System.DateTime EventTime { get; set; }
        public string Location { get; set; }
        public string Message { get; set; }
        public int EventTypeId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }

        public virtual EventType EventType { get; set; }
    }

    public class EventType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public virtual ICollection<Event> Events { get; set; }

    }
}